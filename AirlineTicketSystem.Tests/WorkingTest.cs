using Xunit;
using FluentAssertions;
using AirlineTicketSystem.Models;

namespace AirlineTicketSystem.Tests
{
    public class WorkingTest
    {
        [Fact]
        public void SimpleTest_ShouldPass()
        {
            // Arrange
            var airline = new Airline
            {
                Id = 1,
                Name = "Test Airline",
                Code = "TA",
                Description = "A test airline"
            };

            // Act & Assert
            airline.Should().NotBeNull();
            airline.Id.Should().Be(1);
            airline.Name.Should().Be("Test Airline");
            airline.Code.Should().Be("TA");
            airline.Description.Should().Be("A test airline");
        }

        [Fact]
        public void FlightModel_ShouldWork()
        {
            // Arrange
            var flight = new Flight
            {
                Id = 1,
                FlightNumber = "FL001",
                DepartureCity = "Moscow",
                ArrivalCity = "London",
                DepartureTime = DateTime.Now.AddDays(1),
                ArrivalTime = DateTime.Now.AddDays(1).AddHours(3),
                BasePrice = 500.00m,
                AvailableSeats = 100,
                TotalSeats = 100
            };

            // Act & Assert
            flight.Should().NotBeNull();
            flight.FlightNumber.Should().Be("FL001");
            flight.DepartureCity.Should().Be("Moscow");
            flight.ArrivalCity.Should().Be("London");
            flight.BasePrice.Should().Be(500.00m);
            flight.AvailableSeats.Should().Be(100);
        }

        [Fact]
        public void PassengerModel_ShouldWork()
        {
            // Arrange
            var passenger = new Passenger
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "+1234567890",
                PassportNumber = "AB1234567"
            };

            // Act & Assert
            passenger.Should().NotBeNull();
            passenger.FirstName.Should().Be("John");
            passenger.LastName.Should().Be("Doe");
            passenger.Email.Should().Be("john.doe@example.com");
            passenger.PassportNumber.Should().Be("AB1234567");
        }
    }
}
