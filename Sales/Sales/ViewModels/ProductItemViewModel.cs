﻿
namespace Sales.ViewModels
{
    using System.Linq;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Sales.Common.Models;
    using Sales.Helpers;
    using Services;
    using Xamarin.Forms;

    public class ProductItemViewModel : Product
    {

        #region Attributes

        private ApiService apiService;

        #endregion


        #region Constructors

        public ProductItemViewModel()
        {
            this.apiService = new ApiService();
        }

        #endregion


        #region Commands

        public ICommand DeleteProductCommand
        {
            get {
                return new RelayCommand(DeleteProduct);
            }

        }

        private async void DeleteProduct()
        {
            var answer = await Application.Current.MainPage.DisplayAlert(Languages.Confirm, Languages.DeleteConfirmation, Languages.Yes, Languages.No);
            if(!answer)
            {
                return;
            }

            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, connection.Message, Languages.Accept);
                return;
            }

            var url = Application.Current.Resources["UrlAPI"].ToString();
            var prefix = Application.Current.Resources["UrlPrefix"].ToString();
            var controller = Application.Current.Resources["UrlProductsController"].ToString();
            var response = await this.apiService.Delete(url, prefix, controller, this.ProductId);
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(Languages.Error, response.Message, Languages.Accept);
                return;
            }

            var productsViewModel = ProductsViewModel.GetInstance();
            var deletedProduct = productsViewModel.Products.Where(p => p.ProductId == this.ProductId).FirstOrDefault();
            if (deletedProduct != null)
            {
                productsViewModel.Products.Remove(deletedProduct);
            }


        }
        #endregion
    }
}
