public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
        "Who was the most interesting person you interacted with today?", 
        "What was the best part of my day? What was the hardest?",  
        "How did you see the hand of the Lord in your life today?",
        "What is the overall emotion you're feeling today?",
        "What is one thing you feel most happy about today?",
        "What do you feel like you did well today?",
        "What was the yummiest thing you ate today?",
        "What was the most exciting thing you did today? What about the most mundane?",
        "What are you the most proud of today?",
        "What is the most recent change you've been through?  How have you adjusted?",
        "What was your biggest worry today?",
        "What did you do to take care of yourself today?",
        "Were you more of a positive or negative person today?",
        "What is something you struggled with today?",
        "What is one specific thing you're trying to work on?  How are you working on it?",
        "What are 10 things you would put on your bucket list?",
        "What is something you'd like to learn more about?",
        "What is one thing about your life that you would change?",
        "Who are 5 people that make you feel loved?  Why?",
        "Did you compliment someone today?  Did anyone compliment you?",
        "What is one feature about yourself you would never change?",
        "When do you feel happiest in your skin?",
        "What makes you feel special?",
        "What about you makes you special or unique?",
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, 24);

        return _prompts[promptIndex];
            
    }

}