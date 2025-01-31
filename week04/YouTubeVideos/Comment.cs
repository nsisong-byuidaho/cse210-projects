using System.Collections.Generic;

class Comment
{
    private string _commenter;
    private string _text;
    private List<Comment> _replies; // Creativity line

    public string Commenter => _commenter;
    public string Text => _text;
    public List<Comment> Replies => _replies; // Creativity line

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
        _replies = new List<Comment>(); // Creativity line
    }
    public void AddReply(Comment reply) // Creatvity line
    {
        _replies.Add(reply);
    }
}
