﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LTIWEBAPPDEMO.Migrations
{
    public partial class FkAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Vehicles");
        }
    }
}
