using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Lab6WpfApp;

namespace Lab6WpfApp
{
    class WeatherControl:DependencyObject
    {
        public static readonly DependencyProperty TempProp;
        private string napr;
        private int skor;
        private int osad;

        public int Temp
        {
            get => (int) GetValue(TempProp);
            set => SetValue(TempProp, value);
        }
        public string Napr
        {

            get => napr;

            set => napr = value;

        }
        public int Skor
        {

            get
            {

                return skor;
            }
            set
            {

                if (value > 0 && value < 1000)
                {
                    skor = value;
                }
                else
                {
                    skor = 0;
                }
            }
        }
        public int Osad
        {

            get
            {

                return osad;
            }
            set
            {

                if (value > 0 && value < 4)
                {
                    osad = value;
                }
                else
                {
                    osad = 0;
                }
            }
        }
        public WeatherControl(int temp, string napr,int skor, int osad)
        {
            this.Temp = temp;
            this.Napr = napr;
            this.Skor = skor;
            this.Osad = osad;
         

        }

        static WeatherControl()
        {
            TempProp = DependencyProperty.Register(
                nameof(Temp),
                typeof(int),
                typeof(WeatherControl),
                new FrameworkPropertyMetadata(0,
                FrameworkPropertyMetadataOptions.AffectsMeasure |
                FrameworkPropertyMetadataOptions.AffectsRender,
                null,
                new CoerceValueCallback(CoerceTemp)),
                new ValidateValueCallback(ValidateTemp));
        }

        private static bool ValidateTemp(object value)
        {
            int v = (int)value;
            if (v >= -50 && v <= 50)
                return true;
            else
                return false;
        }

        private static object CoerceTemp(DependencyObject d, object baseValue)
        {
            int v = (int)baseValue;
            if (v >= -50 && v <= 50)
                return v;
            else
                return 0;
        }

        
    }
}
