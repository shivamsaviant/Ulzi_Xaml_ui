using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UlziUI.Classes.AppLanguages;
using UlziUI.Classes.Enums;
using UlziUI.Classes.Models;
using UlziUI.Views.Pages;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppDateSelectorView
    public class AppDateSelectorView : ContentView
    {
        #region Static members
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(AppDateSelectorView), default(string));
        public static readonly BindableProperty TitleTextColorProperty = BindableProperty.Create("TitleTextColor", typeof(Color), typeof(AppDateSelectorView), Color.Black);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create("LineColor", typeof(Color), typeof(AppDateSelectorView), Color.FromHex("#9C9DA1"));
        public static readonly BindableProperty TitleBackgroundProperty = BindableProperty.Create("TitleBackground", typeof(Color), typeof(AppDateSelectorView), Color.FromHex("#F0F0F0"));
        public static readonly BindableProperty DoneCommandProperty = BindableProperty.Create("DoneCommand", typeof(ICommand), typeof(AppDateSelectorView), null);
        public static readonly BindableProperty DoneCommandTextProperty = BindableProperty.Create("DoneCommandText", typeof(string), typeof(AppDateSelectorView), default(string));
        public static readonly BindableProperty DoneCommandTextColorProperty = BindableProperty.Create("DoneCommandTextColor", typeof(Color), typeof(AppDateSelectorView), Color.FromHex("#2F92FD"));
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppDateSelectorView), (double)17);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppDateSelectorView), AppFonts.Quicksand);
        public static readonly BindableProperty SelectedDateProperty = BindableProperty.Create("SelectedDate", typeof(DateTime), typeof(AppDateSelectorView), DateTime.Today);
        public static readonly BindableProperty YearProperty = BindableProperty.Create("Year", typeof(int), typeof(AppDateSelectorView), DateTime.Today.Year);
        public static readonly BindableProperty MonthProperty = BindableProperty.Create("Month", typeof(int), typeof(AppDateSelectorView), DateTime.Today.Month);
        public static readonly BindableProperty DayProperty = BindableProperty.Create("Day", typeof(int), typeof(AppDateSelectorView), DateTime.Today.Day);
        public static readonly BindableProperty MonthsProperty = BindableProperty.Create("Months", typeof(IList), typeof(AppDateSelectorView), null);
        public static readonly BindableProperty SelectedMonthProperty = BindableProperty.Create("SelectedMonth", typeof(PickerItem), typeof(AppDateSelectorView), null);
        public static readonly BindableProperty DaysProperty = BindableProperty.Create("Days", typeof(IList), typeof(AppDateSelectorView), null);
        public static readonly BindableProperty SelectedDayProperty = BindableProperty.Create("SelectedDay", typeof(PickerItem), typeof(AppDateSelectorView), null);
        public static readonly BindableProperty YearsProperty = BindableProperty.Create("Years", typeof(IList), typeof(AppDateSelectorView), null);
        public static readonly BindableProperty SelectedYearProperty = BindableProperty.Create("SelectedYear", typeof(PickerItem), typeof(AppDateSelectorView), null);
        #endregion

        private string[] _months = null;

        private int _prevDay = 0;

        private bool _isInit = false;

        public AppDateSelectorView() : base()
        {
            this.HorizontalOptions = LayoutOptions.Fill;
            this.VerticalOptions = LayoutOptions.End;

            this.BackgroundColor = Color.FromHex("#D2D5DB");

            this.Content = this.CreateContent();

            this.Localize();

            this.InitializeDays();
            this.InitializeYears();
        }

        public void Localize()
        {
            this.InitializeMonths();
        }

        private void InitializeMonths()
        {
            _months = new string[] {
                AppLanguages.CurrentLanguage.MonthSelectorJanuary,
                AppLanguages.CurrentLanguage.MonthSelectorFebruary,
                AppLanguages.CurrentLanguage.MonthSelectorMarch,
                AppLanguages.CurrentLanguage.MonthSelectorApril,
                AppLanguages.CurrentLanguage.MonthSelectorMay,
                AppLanguages.CurrentLanguage.MonthSelectorJune,
                AppLanguages.CurrentLanguage.MonthSelectorJuly,
                AppLanguages.CurrentLanguage.MonthSelectorAugust,
                AppLanguages.CurrentLanguage.MonthSelectorSeptember,
                AppLanguages.CurrentLanguage.MonthSelectorOctober,
                AppLanguages.CurrentLanguage.MonthSelectorNovember,
                AppLanguages.CurrentLanguage.MonthSelectorDecember
            };

            var months = new List<PickerItem>();
            for (int index = 0; index < 200; index++)
            {
                for (int monthIndex = 0; monthIndex < _months.Length; monthIndex++)
                    months.Add(new PickerItem
                    {
                        Id = index * 12 + monthIndex + 1,
                        Name = _months[monthIndex]
                    });
            }

            var month = 1200 + this.Month - 1;

            this.Months = months;
            this.SelectedMonth = months[month];
        }

        private void InitializeDays()
        {
            var days = new List<PickerItem>();
            for (int index = 0; index < 36; index++)
            {
                for (int dayIndex = 0; dayIndex < 31; dayIndex++)
                    days.Add(new PickerItem
                    {
                        Id = index * 31 + dayIndex + 1,
                        Name = (dayIndex + 1).ToString()
                    });
            }

            var day = 18 * 31 + this.Day - 1;

            this.Days = days;
            this.SelectedDay = days[day];
            _prevDay = this.SelectedDay.Id - 1;
        }

        private void InitializeYears()
        {
            var years = new List<PickerItem>();
            for (int index = 0; index < 3001; index++)
                years.Add(new PickerItem
                {
                    Id = index,
                    Name = index.ToString()
                });

            var year = this.Year;

            this.Years = years;
            this.SelectedYear = years[year];
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == SelectedDateProperty.PropertyName)
            {
                _isInit = true;
                try
                {
                    this.UpdateYear();
                    this.UpdateMonth();
                    this.UpdateDay();
                }
                finally
                {
                    _isInit = false;
                }
            }
            else if ((propertyName == YearProperty.PropertyName) ||
                     (propertyName == MonthProperty.PropertyName) ||
                     (propertyName == DayProperty.PropertyName))
            {
                if (propertyName == YearProperty.PropertyName)
                {
                    var selectedYear = (this.Years[this.Year] as PickerItem);
                    if (this.SelectedYear.Id != selectedYear.Id)
                        this.SelectedYear = selectedYear;
                }
                else if (propertyName == MonthProperty.PropertyName)
                {
                    var selectedMonthIndex = (this.SelectedMonth.Id - 1) % 12 + 1;
                    if (selectedMonthIndex != this.Month)
                    {
                        var monthName = _months[this.Month - 1];
                        var searchMonthName = "";
                        var delta = (selectedMonthIndex > this.Month ? -1 : 1);
                        var index = this.Months.IndexOf(this.SelectedMonth);
                        PickerItem selectedMonth = null;
                        while (monthName != searchMonthName)
                        {
                            index += delta;
                            selectedMonth = (this.Months[index] as PickerItem);
                            searchMonthName = selectedMonth.Name;
                        }
                        this.SelectedMonth = selectedMonth;
                    }
                }
                else if (propertyName == DayProperty.PropertyName)
                {
                    var selectedDayIndex = Convert.ToInt32(this.SelectedDay.Name);
                    if (selectedDayIndex != this.Day)
                    {
                        var day = this.Day.ToString();
                        var searchDayName = "";
                        var delta = (selectedDayIndex > this.Day ? -1 : 1);
                        var index = this.Days.IndexOf(this.SelectedDay);
                        PickerItem selectedDay = null;
                        while (day != searchDayName)
                        {
                            index += delta;
                            selectedDay = (this.Days[index] as PickerItem);
                            searchDayName = selectedDay.Name;
                        }
                        this.SelectedDay = selectedDay;
                    }
                }
                this.UpdateSelectedDate();
            }
            else if (propertyName == SelectedMonthProperty.PropertyName)
            {
                var month = (this.SelectedMonth != null ? (this.SelectedMonth.Id - 1) % 12 + 1 : 1);
                var day = (this.SelectedDay != null ? Convert.ToInt32(this.SelectedDay.Name) : 1);
                this.CheckDay(day, month, this.Year);
                if (month != this.Month)
                    this.Month = month;
            }
            else if (propertyName == SelectedDayProperty.PropertyName)
            {
                var day = (this.SelectedDay != null ? Convert.ToInt32(this.SelectedDay.Name) : 1);
                if (day != this.Day)
                {
                    if (!this.CheckDay(day, this.Month, this.Year))
                        this.Day = day;
                }
                _prevDay = this.SelectedDay.Id;
            }
            else if (propertyName == SelectedYearProperty.PropertyName)
            {
                var day = (this.SelectedDay != null ? Convert.ToInt32(this.SelectedDay.Name) : 1);
                var year = (this.SelectedYear != null ? Convert.ToInt32(this.SelectedYear.Name) : 1);
                this.CheckDay(day, this.Month, year);
                if (year != this.Year)
                    this.Year = year;
            }
        }

        private bool CheckDay(int day, int month, int year)
        {
            var result = false;
            var days = this.GetMonthDays(month, year);
            if (day > days)
            {
                var index = this.Days.IndexOf(this.SelectedDay);
                var delta = (_prevDay < this.SelectedDay.Id ? 1 : -1);
                var newDay = day;
                PickerItem selectedDay = null;
                while ((newDay != 1) && (newDay != days))
                {
                    index += delta;
                    selectedDay = (this.Days[index] as PickerItem);
                    newDay = Convert.ToInt32(selectedDay.Name);
                }
                this.SelectedDay = selectedDay;
                result = true;
            }
            return result;
        }

        private int GetMonthDays(int month, int year)
        {
            var days = 0;
            if ((month == 1) ||
                (month == 3) ||
                (month == 5) ||
                (month == 7) ||
                (month == 8) ||
                (month == 10) ||
                (month == 12))
                days = 31;
            else if (month == 2)
                days = (year % 4 == 0 ? 29 : 28);
            else
                days = 30;
            return days;
        }

        private void UpdateSelectedDate()
        {
            if ((!_isInit) &&
                ((this.Year != this.SelectedDate.Year) ||
                 (this.Month != this.SelectedDate.Month) ||
                 (this.Day != this.SelectedDate.Day)))
                this.SelectedDate = new DateTime(this.Year, this.Month, this.Day, this.SelectedDate.Hour, this.SelectedDate.Minute, this.SelectedDate.Minute, this.SelectedDate.Second);
        }

        private void UpdateYear()
        {
            if (this.Year != this.SelectedDate.Year)
                this.Year = this.SelectedDate.Year;
        }

        private void UpdateMonth()
        {
            if (this.Month != this.SelectedDate.Month)
                this.Month = this.SelectedDate.Month;
        }

        private void UpdateDay()
        {
            if (this.Day != this.SelectedDate.Day)
                this.Day = this.SelectedDate.Day;
        }

        private View CreateContent()
        {
            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };
            content.Children.Add(this.CreateLine(), 0, 0);
            content.Children.Add(this.CreateTitle(), 0, 1);
            content.Children.Add(this.CreateLine(), 0, 2);
            content.Children.Add(this.CreateSelector(), 0, 3);
            content.Children.Add(this.CreateIndicator(), 0, 3);

            return content;
        }

        private View CreateLine()
        {
            var line = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 1
            };
            line.SetBinding(ContentView.BackgroundColorProperty, new Binding(LineColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            return line;
        }

        private View CreateTitle()
        {
            var height = MainPage.PageHeight * 0.0660;

            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = height,
                ColumnSpacing = 0,
                RowSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) }
                }
            };
            content.SetBinding(Grid.BackgroundColorProperty, new Binding(TitleBackgroundProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            content.Children.Add(this.CreateTitleText(), 0, 0);
            content.Children.Add(this.CreateDoneCommand(), 1, 0);

            return content;
        }

        private View CreateSelector()
        {
            var height = MainPage.PageHeight * 0.3240;

            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = height,
                Padding = new Thickness(80, 0, 80, 0),
                ColumnSpacing = 10,
                RowSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) }
                }
            };
            content.Children.Add(this.CreateMonthSelector(), 0, 0);
            content.Children.Add(this.CreateDaySelector(), 1, 0);
            content.Children.Add(this.CreateYearSelector(), 2, 0);

            return content;
        }

        private View CreateIndicator()
        {
            var height = 36;
            var indicator = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = height,
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };
            indicator.Children.Add(this.CreateLine(), 0, 0);
            indicator.Children.Add(this.CreateLine(), 0, 2);

            return indicator;
        }

        private View CreateMonthSelector()
        {
            var selector = new AppEnumSelector
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                TextAlignment = TextAlignment.Start
            };
            selector.SetBinding(AppEnumSelector.ItemsProperty, new Binding(MonthsProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            selector.SetBinding(AppEnumSelector.SelectedItemProperty, new Binding(SelectedMonthProperty.PropertyName, BindingMode.TwoWay, null, null, null, this));

            return selector;
        }

        private View CreateDaySelector()
        {
            var selector = new AppEnumSelector
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                TextAlignment = TextAlignment.End
            };
            selector.SetBinding(AppEnumSelector.ItemsProperty, new Binding(DaysProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            selector.SetBinding(AppEnumSelector.SelectedItemProperty, new Binding(SelectedDayProperty.PropertyName, BindingMode.TwoWay, null, null, null, this));

            return selector;
        }

        private View CreateYearSelector()
        {
            var selector = new AppEnumSelector
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                TextAlignment = TextAlignment.End
            };
            selector.SetBinding(AppEnumSelector.ItemsProperty, new Binding(YearsProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            selector.SetBinding(AppEnumSelector.SelectedItemProperty, new Binding(SelectedYearProperty.PropertyName, BindingMode.TwoWay, null, null, null, this));

            return selector;
        }

        private View CreateDoneCommand()
        {
            var doneCommand = new AppCommand
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                Padding = new Thickness(10, 0, 10, 0),
                FontAttributes = FontAttributes.Bold
            };
            doneCommand.SetBinding(AppCommand.TextProperty, new Binding(DoneCommandTextProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.TextColorProperty, new Binding(DoneCommandTextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.CommandProperty, new Binding(DoneCommandProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            return doneCommand;
        }

        private View CreateTitleText()
        {
            var label = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
            };
            label.SetBinding(AppLabel.TextProperty, new Binding(TitleProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.TextColorProperty, new Binding(TitleTextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var content = new ContentView
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill,
                Padding = new Thickness(10, 0, 0, 0),
                Content = label
            };

            return content;
        }

        public string Title
        {
            get { return (string)this.GetValue(TitleProperty); }
            set { this.SetValue(TitleProperty, value); }
        }

        public Color TitleTextColor
        {
            get { return (Color)this.GetValue(TitleTextColorProperty); }
            set { this.SetValue(TitleTextColorProperty, value); }
        }

        public Color LineColor
        {
            get { return (Color)this.GetValue(LineColorProperty); }
            set { this.SetValue(LineColorProperty, value); }
        }

        public Color TitleBackground
        {
            get { return (Color)this.GetValue(TitleBackgroundProperty); }
            set { this.SetValue(TitleBackgroundProperty, value); }
        }

        public ICommand DoneCommand
        {
            get { return (ICommand)this.GetValue(DoneCommandProperty); }
            set { this.SetValue(DoneCommandProperty, value); }
        }

        public string DoneCommandText
        {
            get { return (string)this.GetValue(DoneCommandTextProperty); }
            set { this.SetValue(DoneCommandTextProperty, value); }
        }

        public Color DoneCommandTextColor
        {
            get { return (Color)this.GetValue(DoneCommandTextColorProperty); }
            set { this.SetValue(DoneCommandTextColorProperty, value); }
        }

        public double FontSize
        {
            get { return (double)this.GetValue(FontSizeProperty); }
            set { this.SetValue(FontSizeProperty, value); }
        }

        public AppFonts AppFont
        {
            get { return (AppFonts)this.GetValue(AppFontProperty); }
            set { this.SetValue(AppFontProperty, value); }
        }

        public DateTime SelectedDate
        {
            get { return (DateTime)this.GetValue(SelectedDateProperty); }
            set { this.SetValue(SelectedDateProperty, value); }
        }

        public int Year
        {
            get { return (int)this.GetValue(YearProperty); }
            set { this.SetValue(YearProperty, value); }
        }

        public int Month
        {
            get { return (int)this.GetValue(MonthProperty); }
            set { this.SetValue(MonthProperty, value); }
        }

        public int Day
        {
            get { return (int)this.GetValue(DayProperty); }
            set { this.SetValue(DayProperty, value); }
        }

        public IList Months
        {
            get { return (IList)this.GetValue(MonthsProperty); }
            set { this.SetValue(MonthsProperty, value); }
        }

        public PickerItem SelectedMonth
        {
            get { return (PickerItem)this.GetValue(SelectedMonthProperty); }
            set { this.SetValue(SelectedMonthProperty, value); }
        }

        public IList Days
        {
            get { return (IList)this.GetValue(DaysProperty); }
            set { this.SetValue(DaysProperty, value); }
        }

        public PickerItem SelectedDay
        {
            get { return (PickerItem)this.GetValue(SelectedDayProperty); }
            set { this.SetValue(SelectedDayProperty, value); }
        }

        public IList Years
        {
            get { return (IList)this.GetValue(YearsProperty); }
            set { this.SetValue(YearsProperty, value); }
        }

        public PickerItem SelectedYear
        {
            get { return (PickerItem)this.GetValue(SelectedYearProperty); }
            set { this.SetValue(SelectedYearProperty, value); }
        }
    }
    #endregion
}
