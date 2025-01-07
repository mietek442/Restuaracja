using Api.Domain.Models;
using Api.Features.TableReservations.Helpers;

namespace Api.Features.TableReservations.Commands.CreateReservation
{
    public static class ReservationMapper
    {
        public static TableReservation toReservation(this ReservationRequest request) {
            return new TableReservation
            {
                ClientName = request.ClientName,
                TableId = request.TableId,
                StartTime = request.StartTime,
                EndTime = request.EndTime,
            };
        }
        public static ReservationResponse toResponse(this TableReservation request) {
            return new ReservationResponse
            {
                Id = request.Id,
                ClientName = request.ClientName,
                TableId = request.TableId,
                StartTime = request.StartTime,
                EndTime = request.EndTime,
            };
        }
    }
}
