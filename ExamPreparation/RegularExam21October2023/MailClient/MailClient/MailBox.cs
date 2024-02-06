using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
            Capacity = capacity;
        }

        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive {  get; set; }
        public int Capacity { get; set; }


        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count==Capacity)
            {
                return;
            }
            Inbox.Add(mail);
        }
        public bool DeleteMail(string sender) => Inbox.Remove(Inbox.FirstOrDefault(x => x.Sender == sender));

        public int ArchiveInboxMessages()
        {
            Archive = Inbox.ToList();
            int mailsMoved = Inbox.Count();
            Inbox.Clear();
            return mailsMoved;
        }

        public string GetLongestMessage()
        {
            Mail longestMail = Inbox.OrderByDescending(m => m.Body.Length).FirstOrDefault();
            return longestMail.ToString();
        }
        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (var item in Inbox)
            {
                sb.AppendLine(item.ToString());

            }
            return sb.ToString().Trim();
        }
    }
}
