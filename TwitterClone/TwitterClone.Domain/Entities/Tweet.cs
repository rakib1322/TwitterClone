
namespace TwitterClone.Domain.Entities
{
    internal class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;

        public Tweet()
        {
            _id = Guid.NewGuid();
            _authorId = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid _authorId
        {
            get { _authorId; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
