namespace HotelProject.WebUI.Dtos.Room
{
    public class AddRoomDto
    {
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        public int Price { get; set; }

        public string Title { get; set; }

        public int BedCount { get; set; }

        public int BathCount { get; set; }

        public bool Wifi { get; set; }

        public string Description { get; set; }
    }
}
