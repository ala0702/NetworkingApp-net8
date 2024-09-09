namespace Extentions.API;

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateOnly dob){

        var today = DateOnly.FromDateTime(DateTime.Now);
        var age = today.Year - dob.Year; // what if this year already we had birthday??

        if (dob> today.AddYears(-age)) age--;

        return age;
    }
}