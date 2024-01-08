using System.ComponentModel.DataAnnotations;

namespace SocialNetworkFinal.ViewModels
{
    public enum Months
    {
        [Display(Name = "Январь")]
        Jan = 1,
        [Display(Name = "Февраль")]
        Feb = 2,
        [Display(Name = "Март")]
        March = 3,
        [Display(Name = "Апрель")]
        Apr = 4,
        [Display(Name = "Май")]
        May = 5,
        [Display(Name = "Июнь")]
        June = 6,
        [Display(Name = "Июль")]
        July = 7,
        [Display(Name = "Август")]
        Aug = 8,
        [Display(Name = "Сентябрь")]
        Sept = 9,
        [Display(Name = "Октябрь")]
        Okt = 10,
        [Display(Name = "Ноябрь")]
        Nov = 11,
        [Display(Name = "Декабрь")]
        Dec = 12,
    }
}
