﻿// <auto-generated>

using Microsoft.EntityFrameworkCore.Migrations;

namespace WebWorkshopManager.Entities.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "engines",
                columns: table => new
                {
                    EngineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    HorsePower = table.Column<int>(nullable: false),
                    FuelType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_engines", x => x.EngineId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ProductType = table.Column<int>(nullable: false),
                    QuantityInStock = table.Column<decimal>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Permissions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    EngineId = table.Column<int>(nullable: true),
                    EngineNumber = table.Column<string>(nullable: true),
                    Vin = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    LicensePlate = table.Column<string>(nullable: false),
                    Mileage = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_cars_engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "engines",
                        principalColumn: "EngineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    RoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobNumber = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    WorkerId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    CarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_jobs_cars_CarId",
                        column: x => x.CarId,
                        principalTable: "cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jobs_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jobs_users_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "job_items",
                columns: table => new
                {
                    JobItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_items", x => x.JobItemId);
                    table.ForeignKey(
                        name: "FK_job_items_jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_job_items_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "CustomerId", "ContactNumber", "Email", "Name" },
                values: new object[] { 1, "0879590946", "borislav.nikolov.37@gmail.com", "Борислав Николаев Николов" });

            migrationBuilder.InsertData(
                table: "engines",
                columns: new[] { "EngineId", "FuelType", "HorsePower", "Name" },
                values: new object[,]
                {
                    { 1, 2, 101, "1.9 TDI" },
                    { 2, 1, 150, "1.8T" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductId", "Name", "ProductType", "QuantityInStock", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Смяна на масло", 3, 1m, 2.40m },
                    { 2, "Масло Castrol EDGE Turbo Diesel Titanium FST 5W40 - 4Л", 1, 5m, 57m },
                    { 3, "Труд", 4, 1m, 5.2m }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "RoleId", "Name", "Permissions" },
                values: new object[] { 1, "Системен администратор", 254 });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "CarId", "Brand", "EngineId", "EngineNumber", "LicensePlate", "Mileage", "Model", "Vin", "Year" },
                values: new object[] { 1, "Volkswagen", 1, "ATD496532", "BP3666CC", 212654.451m, "Golf 4", "WVWZZZ1JZ3W584008", 2003 });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "Email", "Name", "Password", "RoleId" },
                values: new object[] { 1, "admin@autoservicesoft.com", "admin", "21232f297a57a5a743894a0e4a801fc3", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_cars_EngineId",
                table: "cars",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_job_items_JobId",
                table: "job_items",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_job_items_ProductId",
                table: "job_items",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_CarId",
                table: "jobs",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_CustomerId",
                table: "jobs",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_WorkerId",
                table: "jobs",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_users_RoleId",
                table: "users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "job_items");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "engines");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
