using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace MSFTLogo
{
    public sealed partial class AnimatableQuadrant : UserControl
    {
        public AnimatableQuadrant()
        {
            this.InitializeComponent();
        }
        public string ImagePath
        {
            get => (string)GetValue(ImagePathProperty);
            set => SetValue(ImagePathProperty, value);
        }

        public static readonly DependencyProperty ImagePathProperty = DependencyProperty.Register("ImagePath", typeof(string), typeof(AnimatableQuadrant), new PropertyMetadata(string.Empty));

        public TimeSpan? Delay
        {
            get => (TimeSpan?)GetValue(DelayProperty);
            set => SetValue(DelayProperty, value);
        }

        public static readonly DependencyProperty DelayProperty = DependencyProperty.Register("Delay", typeof(TimeSpan?), typeof(AnimatableQuadrant), new PropertyMetadata(new TimeSpan(0)));


        public SolidColorBrush OverlayColor
        {
            get => (SolidColorBrush)GetValue(OverlayColorProperty);
            set => SetValue(OverlayColorProperty, value);
        }

        public static readonly DependencyProperty OverlayColorProperty = DependencyProperty.Register("OverlayColor", typeof(SolidColorBrush), typeof(AnimatableQuadrant), new PropertyMetadata(Colors.White));

        public void ZoomIn()
        {
            ImageHolder.Visibility = Visibility.Visible;
            ZoomInAnimation.Start();
        }

        public void ZoomOut()
        {
            ImageHolder.Visibility = Visibility.Collapsed;
            ZoomOutAnimation.Start();
        }
    }
}
