using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Kyxo
{
    public partial class MainWindow : Window
    {
        // Kyxo Softworks (c) 2020-2021
        /* - Make sure to credit us if u were to use this template.
           - We cleared the source so gtfo skids 
           - The user interface is resizeable, we left all the styles so feel free to use it, but dont forget to credit or gonna get exposed 
           - CREDITS:
             - Fadh#1107 --- publishing source
             - orbx#5832 --- make everything and coded this ui
        */

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            bool IsSettingsBarOpen = SettingsBar.Opacity == 0 && SettingsBar.Margin ==
                new Thickness(-40) ? false : true;

            if (!IsSettingsBarOpen)
            {
                DoubleAnimation DoubleAnimationIn = new DoubleAnimation()
                {
                    Duration = new Duration(TimeSpan.FromMilliseconds(450)),
                    EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseInOut },
                    DecelerationRatio = 0.3f,
                    From = SettingsBar.Opacity,
                    To = 1,
                };

                ThicknessAnimation ThicknessAnimationIn = new ThicknessAnimation()
                {
                    Duration = new Duration(TimeSpan.FromMilliseconds(500)),
                    EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseInOut },
                    DecelerationRatio = 0.3f,
                    From = SettingsBar.Margin,
                    To = new Thickness(0),
                };

                SettingsBar.BeginAnimation(OpacityProperty, DoubleAnimationIn);
                SettingsBar.BeginAnimation(MarginProperty, ThicknessAnimationIn);
            }
            else
            {
                DoubleAnimation DoubleAnimationOut = new DoubleAnimation()
                {
                    Duration = new Duration(TimeSpan.FromMilliseconds(450)),
                    EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseInOut },
                    DecelerationRatio = 0.3f,
                    From = SettingsBar.Opacity,
                    To = 0,
                };

                ThicknessAnimation ThicknessAnimationOut = new ThicknessAnimation()
                {
                    Duration = new Duration(TimeSpan.FromMilliseconds(500)),
                    EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseInOut },
                    DecelerationRatio = 0.3f,
                    From = SettingsBar.Margin,
                    To = new Thickness(-40),
                };

                SettingsBar.BeginAnimation(MarginProperty, ThicknessAnimationOut);
                SettingsBar.BeginAnimation(OpacityProperty, DoubleAnimationOut);
            }
        }
    }
}
