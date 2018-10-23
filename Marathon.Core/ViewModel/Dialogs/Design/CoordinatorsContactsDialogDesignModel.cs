﻿using Marathon.Core.ViewModel.Input;

namespace Marathon.Core.ViewModel.Dialogs.Design
{
    /// <summary>
    /// The design-time data for a <see cref="CoordinatorsContactsDialogViewModel"/>
    /// </summary>
    public class CoordinatorsContactsDialogDesignModel : CoordinatorsContactsDialogViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static CoordinatorsContactsDialogDesignModel Instance => new CoordinatorsContactsDialogDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CoordinatorsContactsDialogDesignModel()
        {
            Title = "Контакты";
            Message = "Для получения дополнительной информации пожалуйста свяжитесь с координаторами";

            Contacts = new[]
            {
                new EntryViewModel<string>("Телефон")
                {
                    Value = "+55 11 9988 7766"
                },
                new EntryViewModel<string>("Email")
                {
                    Value = "+coordinators@marathonskills.org"
                },
            };
        }

        #endregion
    }
}