using PurchaseOrder.Model;
using PurchaseOrder.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.Data.Interfaces {
    public interface INotificationRepository {
        Task CreateAsync(List<Notification> notifications);
        Task<List<Notification>?> GetAsync(long orderId);
    }
}
