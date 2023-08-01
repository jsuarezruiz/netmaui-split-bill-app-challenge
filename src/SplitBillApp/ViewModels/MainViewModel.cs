using CommunityToolkit.Mvvm.ComponentModel;
using SplitBillApp.Models;
using SplitBillApp.Services;
using System.Collections.ObjectModel;

namespace SplitBillApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        readonly PeopleService _peopleService;
        readonly RecentPaymentsService _recentPaymentsService;

        ObservableCollection<Payment> _recentPayments;
        ObservableCollection<Friend> _friends;

        public MainViewModel(PeopleService peopleService, RecentPaymentsService recentPaymentsService)
        {
            _peopleService = peopleService;
            _recentPaymentsService = recentPaymentsService;

            LoadData();
        }

        public ObservableCollection<Payment> RecentPayments
        {
            get { return _recentPayments; }
            set
            {
                _recentPayments = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Friend> Friends
        {
            get { return _friends; }
            set
            {
                _friends = value;
                OnPropertyChanged();
            }
        }

        void LoadData()
        {
            RecentPayments = new ObservableCollection<Payment>(_recentPaymentsService.GetRecentPayments());
            Friends = new ObservableCollection<Friend>(_peopleService.GetFriends());
        }
    }
}