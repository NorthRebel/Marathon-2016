﻿using System;
using System.Windows.Input;
using Marathon.Core.Helpers;
using System.Threading.Tasks;
using Marathon.Core.Models.User;
using Marathon.Core.Services.User;
using Marathon.Core.ViewModel.Base;
using Marathon.Core.ViewModel.Dialogs;
using Marathon.Core.ViewModel.PageCaption;

namespace Marathon.Core.ViewModel
{
    using Kernel = IoC.IoC;

    /// <summary>
    /// The view model for a SignIn page
    /// </summary>
    public class SignInViewModel : PageViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Try to sign in user
        /// </summary>
        public ICommand SignInCommand { get; set; }

        /// <summary>
        /// Cancel sign in of user
        /// </summary>
        public ICommand CancelCommand { get; set; }

        #endregion

        #region Constructor

        public SignInViewModel()
        {
            PageCaption = new PageCaptionViewModel("Форма авторизации",
                "Пожалуйста, авторизуйтесь в системе, используя ваш адрес электронной почты и пароль");

            SignInCommand = new RelayCommand(async (password) => await SignInAsync(password));
            CancelCommand = new RelayCommand(x => Cancel());
        }

        #endregion

        #region Commands Helpers

        /// <summary>
        /// Go to previous page
        /// </summary>
        private void Cancel()
        {
            Kernel.Get<ApplicationViewModel>().GoToPreviousPage();
        }

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        private async Task SignInAsync(object password)
        {
            var userService = Kernel.Get<IUserService>();

            try
            {
                var pass = (password as IHavePassword).SecurePassword.Unsecure();

                UserInfo result = await userService.SignInAsync(Email, pass);

                await Kernel.Application.HandleSuccessfulLoginAsync(result);
            }
            catch (Exception)
            {
                await Kernel.UI.ShowMessage(new MessageBoxDialogViewModel
                {
                    Title = "Ошибка",
                    Message = "Не удалось авторизовать пользователя!"
                });
            }
        }

        #endregion
    }
}
