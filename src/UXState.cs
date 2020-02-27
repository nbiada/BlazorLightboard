using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLightboard
{
    public class UXState
    {
        public bool NavBarDisplay { get; private set; }
        public bool SlideInDisplay { get; private set; }
        public string SlideInClass { get; private set; }
        public string ReverseName { get; private set; }
        public string FirstName { get; private set; }
        public string DefaultFirstName { get; private set; } = "Who?";
        private int _counter;
        public int Counter
        {
            get
            {
                return _counter;
            }
            set
            {
                _counter = value;
                NotifyStateChanged();
            }
        }


        public event Action OnChange;


        private string _name;

        public UXState()
        {
            NavBarDisplay = true;
        }

        public void SetNavBarDisplay(bool visible)
        {
            NavBarDisplay = visible;
            NotifyStateChanged();
        }
        public void SetSlideInDisplay(bool visible)
        {
            SlideInDisplay = visible;
            if (visible)
            {
                SlideInClass = "slidebar-open";
            }
            else
            {
                SlideInClass = string.Empty;
            }
            NotifyStateChanged();
        }

        public void ToggleSlideIn()
        {
            SetSlideInDisplay(!SlideInDisplay);
        }
        public void ToggleNavBar()
        {
            SetNavBarDisplay(!NavBarDisplay);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                SetReverseName(value);
                SetFirstName(value);
                NotifyStateChanged();
            }
        }

        public void SetReverseName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                ReverseName = ReverseStringDirect(name);
            }
            else
            {
                ReverseName = "";
            }
        }
        public void SetFirstName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Equals(DefaultFirstName))
            {
                FirstName = DefaultFirstName;
            }
            else
            {
                FirstName = GetFirstWord(name);
            }
        }

        private static string ReverseStringDirect(string s)
        {
            char[] array = new char[s.Length];
            int forward = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }
        private static string GetFirstWord(string s)
        {
            return String.Join("", s.TakeWhile(x => Char.IsLetter(x)));
        }

        public int KeyValueToInt(object keyValue)
        {
            if (keyValue == null)
            {
                return 0;
            }
            try
            {
                var strValue = keyValue.ToString();
                return Convert.ToInt32(strValue);
            }
            catch
            {
                return 0;
            }
        }
        public string KeyValueToString(object keyValue)
        {
            if (keyValue == null)
            {
                return "";
            }
            try
            {
                var strValue = keyValue.ToString();
                return strValue;
            }
            catch
            {
                return "";
            }
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
