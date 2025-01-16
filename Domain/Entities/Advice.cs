namespace Domain.Entities
{
    public class Advice
    {
        public int Id { get; private set; }
        public string Text { get; private set; }

        public Advice(int id, string text)
        {
            Id = id;
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
    }
}
