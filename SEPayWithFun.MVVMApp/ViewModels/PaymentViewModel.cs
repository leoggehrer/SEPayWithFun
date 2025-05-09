﻿//@GeneratedCode
/*****************************************************************************************
  Please note that this file is regenerated each time it is generated
  and all your changes will be overwritten in this file.
  If you still want to make changes, you can do this in 2 ways:
  
  1. Use a 'partial class name' according to the following pattern:
  
  #if GENERATEDCODE_ON
  namespace_name {
    partial class ClassName
    {
      partial void BeforeExecute(ref bool handled)
      {
        //... do something
        handled = true;
      }
    }
   }
  #endif
  
  2. Change the label //@GeneratedCode to //@CustomizedCode, for example.
     Alternatively, you can also remove the label or give it a different name.
*****************************************************************************************/
namespace SEPayWithFun.MVVMApp.ViewModels
{
    using System;
    /// <summary>
    /// Generated by the generator.
    /// </summary>
    public partial class PaymentViewModel : GenericItemViewModel<Models.Payment>
    {
        /// <summary>
        /// Initializes the class (created by the generator).
        /// </summary>
        static PaymentViewModel()
        {
            ClassConstructing();
            ClassConstructed();
        }
        /// <summary>
        /// This method is called before the construction of the class.
        /// </summary>
        static partial void ClassConstructing();
        /// <summary>
        /// This method is called when the class is constructed.
        /// </summary>
        static partial void ClassConstructed();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentViewModel"/> class (created by the generator.)
        /// </summary>
        public PaymentViewModel()
        {
            Constructing();

            Constructed();
        }
        /// <summary>
        /// This method is called the object is being constraucted.
        /// </summary>
        partial void Constructing();
        /// <summary>
        /// This method is called when the object is constructed.
        /// </summary>
        partial void Constructed();

        /// <summary>
        /// Property 'CardNumberWithoutSpaces' generated by the generator.
        /// </summary>
        public System.String CardNumberWithoutSpaces
        {
            get
            {
                return Model.CardNumberWithoutSpaces;
            }
            set
            {
                Model.CardNumberWithoutSpaces = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property 'ExecutionDate' generated by the generator.
        /// </summary>
        public System.DateTime ExecutionDate
        {
            get
            {
                return Model.ExecutionDate;
            }
            set
            {
                Model.ExecutionDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property 'TurnoverTime' generated by the generator.
        /// </summary>
        public System.DateTime TurnoverTime
        {
            get
            {
                return Model.TurnoverTime;
            }
            set
            {
                Model.TurnoverTime = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property 'DealerName' generated by the generator.
        /// </summary>
        public System.String DealerName
        {
            get
            {
                return Model.DealerName;
            }
            set
            {
                Model.DealerName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property 'DealerLocation' generated by the generator.
        /// </summary>
        public System.String DealerLocation
        {
            get
            {
                return Model.DealerLocation;
            }
            set
            {
                Model.DealerLocation = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property 'Turnover' generated by the generator.
        /// </summary>
        public System.Decimal Turnover
        {
            get
            {
                return Model.Turnover;
            }
            set
            {
                Model.Turnover = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property 'Note' generated by the generator.
        /// </summary>
        public System.String? Note
        {
            get
            {
                return Model.Note;
            }
            set
            {
                Model.Note = value;
                OnPropertyChanged();
            }
        }
    }
}
