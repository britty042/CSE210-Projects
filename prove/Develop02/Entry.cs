public class Entry
{
        public string _date;
        public string _promptText;
        public string _response;
        public string _gratitude;

        public void Display()
        {
            Console.WriteLine($"Date: {_date} Prompt: {_promptText}");
            Console.WriteLine($"{_response}");
            Console.WriteLine($"{_gratitude}");
        }

        public string GenerateFileOutput()
        {
            return $"{_date}|{_promptText}|{_response}| I am grateful for: {_gratitude}";
        }
}