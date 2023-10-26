namespace RapidBlazor.Services
{
    public class ThemeService
    {
        public bool IsDarkMode { get; set; } = false;

        public event Action OnThemeChanged;


        public void ToggleTheme()
        {
            IsDarkMode = !IsDarkMode;
            NotifyThemeChanged();
        }

        private void NotifyThemeChanged()
        {
            OnThemeChanged?.Invoke();
        }

    }
}
