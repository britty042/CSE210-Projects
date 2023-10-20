using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //creates 3-4 videos, sets values
        Video v1 = new Video("Silly Cat", "James McNilly", 120);
        
        videos.Add(v1);
        List<Comment> comments1 = new List<Comment>
        {
            new Comment("Ralph Jacobs", "This cat is so funny!"),
            new Comment("Roger", "Silliest video I've ever seen!"),
            new Comment("Candice Coombs", "Do you think they trained the cat to do that?"),
            new Comment("Jack C.", "I feel like I just wasted 2 minutes of my life."),
        };
        v1.SetCommentsList(comments1);

        Video v2 = new Video("Dancing Dolphins","Sally O'Malley",175);
        videos.Add(v2);
        List<Comment> comments2 = new List<Comment>
        {
            new Comment("Sandy James", "I would love to see something like this in real life!"),
            new Comment("Julie June", "They have the happiest expressions on their faces!"),
            new Comment("Barbara", "I've seen this happen! It's amazing!"),
            new Comment("Daniel Lane", "This is on my wife's bucket list!  We'll see it someday!"),
        };
        v2.SetCommentsList(comments2);

        Video v3 = new Video("Grandma Gets Run Over by a Reindeer","Jimmy P. Elf",92);
        videos.Add(v3);
        List<Comment> comments3 = new List<Comment>
        {
            new Comment("Santa C.", "This was supposed to stay between you and me.  Come to my office."),
            new Comment("Donner the Reindeer", "She just came out of no where.  I still calim innocent."),
            new Comment("Sarah Elf", "A little Christmas magic could've saved her!  What were you thinking!?"),
            new Comment("Mrs. C", "This is not funny. Santa, you're on the naughty list!"),
        };
        v3.SetCommentsList(comments3);
    


        //iterate through the list of videos and display title, author, length and & of comments, then list the comments
        foreach (Video video in videos)
        {
            video.Display();

        }
    }
}