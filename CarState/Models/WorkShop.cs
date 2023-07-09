namespace CarState.Models
{
    public class WorkShop
    {
        public int Id { get; set; }
        public ICollection<Worker> Workers { get; set; }   
        
        public bool HasThiefWorker(ICollection<Worker> workers)
        {
            return workers.Any(q => q.IsThief);
        }
    }
}
