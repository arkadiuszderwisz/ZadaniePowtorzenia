using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Lab3_test2.Models
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class FormModel
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Ilość powtórzeń")]
        public int Powtorzenia { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
