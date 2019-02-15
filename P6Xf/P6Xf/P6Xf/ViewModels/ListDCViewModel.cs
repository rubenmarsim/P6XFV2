using P6Xf.Models;
using P6Xf.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace P6Xf.ViewModels
{
    public class ListDCViewModel : ViewModelBase
    {
        public ListDCModel lstDC { get; set; }
        public ListDCViewModel()
        {
            lstDC = new ListDCModel
            {
                Title = "Practica 6 Xamafin Forms por Ruben Martinez, lista de superheroes de DC"
            };
        }
    }
}
