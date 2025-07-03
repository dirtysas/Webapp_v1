﻿


namespace WebApp.Shared.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }

        
        public List<OrderViewModel> Orders { get; set; } = new();
    }
}