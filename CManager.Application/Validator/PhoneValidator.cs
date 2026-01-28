public static class PhoneValidator
{
    public static bool IsValid(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return false;
        var trimmedPhone = phoneNumber.Replace(" ", string.Empty).Replace("-", "").Replace("(", "").Replace(")", "").Replace("+", "00");
        //004670123456789
        if (trimmedPhone.Length < 9 || trimmedPhone.Length > 15)
            return false;

        return trimmedPhone.All(char.IsDigit);
    }

}

