namespace BookShop.Const
{
    public class RegExps
    {
        public const string Name = @"[А-Я]{1}[а-я-]+$";
        public const string MiddleName = @"[А-Я]{1}[а-я-]+$|^$";
        public const string Phone = @"^\+375\((29|44|33|25)\)\d{3}-\d\d-\d\d$";    //+375(29||33||25||44)XXX-XX-XX
        public const string Email = @"^\w+.+@\w+\.\w+$";
    }
}
