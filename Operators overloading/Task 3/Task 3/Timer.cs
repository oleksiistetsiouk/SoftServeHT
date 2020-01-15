using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Timer
    {
        private int minute;
        private int second;
        private int millisecond;

        public Timer()
        {
        }

        public Timer(int minute, int second, int millisecond)
        {
            Minute = minute;
            Second = second;
            Millisecond = millisecond;
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 60)
                    throw new ArgumentOutOfRangeException();
                else
                    minute = value;
            }
        }

        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (value > 60)
                {
                    Minute += value / 60;
                    second = value % 60;
                }
                else
                    second = value;
            }
        }

        public int Millisecond
        {
            get { return millisecond; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (value > 60)
                {
                    Second += value / 60;
                    millisecond = value % 60;
                }
                else
                    millisecond = value;
            }
        }

        public static bool operator <(Timer timer1, Timer timer2)
        {
            if (timer1.Minute != timer2.Minute)
                return timer1.Minute < timer2.Minute;

            if (timer1.Second != timer2.Second)
                return timer1.Second < timer2.Second;

            if (timer1.Millisecond != timer2.Millisecond)
                return timer1.Millisecond < timer2.Millisecond;

            return true;
        }

        public static bool operator >(Timer timer1, Timer timer2)
        {
            if (timer1.Minute != timer2.Minute)
                return timer1.Minute > timer2.Minute;

            if (timer1.Second != timer2.Second)
                return timer1.Second > timer2.Second;

            if (timer1.Millisecond != timer2.Millisecond)
                return timer1.Millisecond > timer2.Millisecond;

            return true;
        }

        public static bool operator <=(Timer timer1, Timer timer2)
        {
            if (timer1.Minute == timer2.Minute && timer1.Second == timer2.Second && timer1.Millisecond == timer2.Millisecond)
                return true;

            if (timer1.Minute != timer2.Minute)
                return timer1.Minute < timer2.Minute;

            if (timer1.Second != timer2.Second)
                return timer1.Second < timer2.Second;

            if (timer1.Millisecond != timer2.Millisecond)
                return timer1.Millisecond < timer2.Millisecond;

            return true;
        }

        public static bool operator >=(Timer timer1, Timer timer2)
        {
            if (timer1.Minute == timer2.Minute && timer1.Second == timer2.Second && timer1.Millisecond == timer2.Millisecond)
                return true;

            if (timer1.Minute != timer2.Minute)
                return timer1.Minute > timer2.Minute;

            if (timer1.Second != timer2.Second)
                return timer1.Second > timer2.Second;

            if (timer1.Millisecond != timer2.Millisecond)
                return timer1.Millisecond > timer2.Millisecond;

            return true;
        }

        public static bool operator ==(Timer timer1, Timer timer2)
        {
            return (timer1.Minute == timer2.Minute && timer1.Second == timer2.Second && timer1.Millisecond == timer2.Millisecond);
        }

        public static bool operator !=(Timer timer1, Timer timer2)
        {
            return (timer1.Minute != timer2.Minute || timer1.Second != timer2.Second || timer1.Millisecond != timer2.Millisecond);
        }

        public override string ToString()
        {
            return $"{Minute}m:{Second}s:{Millisecond}ms";
        }
    }
}