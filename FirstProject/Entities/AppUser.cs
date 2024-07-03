using Microsoft.AspNetCore.Identity;

namespace FirstProject.Entities
{
    public class AppUser:IdentityUser
    {
        public string OTP { get; set; }

        public string FullName { get; set; }

        public int CheckOTP { get; set; }

        public DateTime OTPtimer { get; set; }

    }
}
