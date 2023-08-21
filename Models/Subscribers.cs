using System.ComponentModel.DataAnnotations;

namespace HSTV_Api.Models
{
    public class Subscribers
    {
        [Key]
        public int SubscriberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Kc_phone_number { get; set; }
        public bool Is_kc_confirmed { get; set; }
        public Country Country { get; set; }
        public string Ip_address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Language { get; set; }
        public DateTime Birthday_Date { get; set; }
        public int Participants { get; set; }
        public int ZoneId { get; set; }
        public int FamilyId { get; set; }
        public int Vc_Id { get; set; }
        public DateTime Login_time { get; set; }
        public DateTime CurrentTime { get; set; }
        public bool Is_valid_email { get; set; }
        public int Seen { get; set; }
        public int Presubscribed { get; set; }
        public int Gmfs_registered { get; set; }
        public string Previous_student { get; set; }
        public int Financial_partner { get; set; }
        public int Partner { get; set; }
        public string Donation_categories { get; set; }
        public DateTime Partner_regdate { get; set; }
        public int Translator { get; set; }
        public string Httnlive { get; set; }
        public string Exhibition { get; set; }
        public string Hsopc { get; set; }
        public int Hsopc_moved { get; set; }
        public string Hslhs { get; set; }
        public string Gdop { get; set; }
        public string Ylw { get; set; }
        public string View_lang { get; set; }
        public int Db_moved { get; set; }
        public int Unsubscribed { get; set; }
    }
}
