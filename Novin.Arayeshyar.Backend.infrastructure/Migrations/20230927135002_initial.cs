using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Novin.Arayeshyar.Backend.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    PostalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alley = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaque = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.PostalCode);
                });

            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    CostCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.CostCode);
                });

            migrationBuilder.CreateTable(
                name: "MakeUps",
                columns: table => new
                {
                    MakeUpCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakeUpType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUps", x => x.MakeUpCode);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MakeUpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarberCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttendanceTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderCode);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BarberCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakeUpCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deposit = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationCode);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    SurveyCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.SurveyCode);
                });

            migrationBuilder.CreateTable(
                name: "SystemManagers",
                columns: table => new
                {
                    ManagerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemManagers", x => x.ManagerCode);
                });

            migrationBuilder.CreateTable(
                name: "BarberOwners",
                columns: table => new
                {
                    BarberOwnerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressPostalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicenseCode = table.Column<int>(type: "int", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarberOwners", x => x.BarberOwnerCode);
                    table.ForeignKey(
                        name: "FK_BarberOwners_Addresses_AddressPostalCode",
                        column: x => x.AddressPostalCode,
                        principalTable: "Addresses",
                        principalColumn: "PostalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BarberShops",
                columns: table => new
                {
                    BarberShopCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressPostalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarberShops", x => x.BarberShopCode);
                    table.ForeignKey(
                        name: "FK_BarberShops_Addresses_AddressPostalCode",
                        column: x => x.AddressPostalCode,
                        principalTable: "Addresses",
                        principalColumn: "PostalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Barbers",
                columns: table => new
                {
                    BarberCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddreesPostalCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbers", x => x.BarberCode);
                    table.ForeignKey(
                        name: "FK_Barbers_Addresses_AddreesPostalCode",
                        column: x => x.AddreesPostalCode,
                        principalTable: "Addresses",
                        principalColumn: "PostalCode");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressPostalCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerCode);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressPostalCode",
                        column: x => x.AddressPostalCode,
                        principalTable: "Addresses",
                        principalColumn: "PostalCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BarberOwners_AddressPostalCode",
                table: "BarberOwners",
                column: "AddressPostalCode");

            migrationBuilder.CreateIndex(
                name: "IX_BarberShops_AddressPostalCode",
                table: "BarberShops",
                column: "AddressPostalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Barbers_AddreesPostalCode",
                table: "Barbers",
                column: "AddreesPostalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressPostalCode",
                table: "Customers",
                column: "AddressPostalCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarberOwners");

            migrationBuilder.DropTable(
                name: "BarberShops");

            migrationBuilder.DropTable(
                name: "Barbers");

            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MakeUps");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "SystemManagers");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
