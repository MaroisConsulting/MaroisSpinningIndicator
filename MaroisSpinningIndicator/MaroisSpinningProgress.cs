using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MaroisSpinningIndicator
{
    public class MaroisSpinningProgress : Control
    {
        #region DP IndicatorColor
        public static readonly DependencyProperty IndicatorColorProperty =
                    DependencyProperty.Register("IndicatorColor",
                    typeof(SolidColorBrush),
                    typeof(MaroisSpinningProgress),
                    new PropertyMetadata(new SolidColorBrush(Colors.Black), new PropertyChangedCallback(OnIndicatorColorChanged)));

        public SolidColorBrush IndicatorColor
        {
            get { return (SolidColorBrush)GetValue(IndicatorColorProperty); }
            set { SetValue(IndicatorColorProperty, value); }
        }

        private static void OnIndicatorColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (MaroisSpinningProgress)d;
        }
        #endregion

        #region DP IndicatorTextColor
        public static readonly DependencyProperty IndicatorTextColorProperty =
                    DependencyProperty.Register("IndicatorTextColor",
                    typeof(SolidColorBrush),
                    typeof(MaroisSpinningProgress),
                    new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        public SolidColorBrush IndicatorTextColor
        {
            get { return (SolidColorBrush)GetValue(IndicatorTextColorProperty); }
            set { SetValue(IndicatorTextColorProperty, value); }
        }
        #endregion

        #region DP Message
        public static readonly DependencyProperty MessageProperty =
                    DependencyProperty.Register("Message",
                    typeof(string),
                    typeof(MaroisSpinningProgress),
                    new PropertyMetadata("", new PropertyChangedCallback(OnMessageChanged)));

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        private static void OnMessageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (MaroisSpinningProgress)d;
        }
        #endregion

        #region CTOR
        public MaroisSpinningProgress()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaroisSpinningProgress),
                new FrameworkPropertyMetadata(typeof(MaroisSpinningProgress)));
        }
        #endregion
    }
}
