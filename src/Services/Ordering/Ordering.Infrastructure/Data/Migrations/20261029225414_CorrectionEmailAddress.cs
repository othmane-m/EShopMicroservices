using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ordering.Infrastructure.Data.Migrations;

/// <inheritdoc />
public partial class CorrectionEmailAddress : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "ShippingAddress_EmailName",
            table: "Orders",
            newName: "ShippingAddress_EmailAddress");

        migrationBuilder.RenameColumn(
            name: "BillingAddress_EmailName",
            table: "Orders",
            newName: "Payment_CardName");

        migrationBuilder.AddColumn<string>(
            name: "BillingAddress_EmailAddress",
            table: "Orders",
            type: "nvarchar(50)",
            maxLength: 50,
            nullable: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "BillingAddress_EmailAddress",
            table: "Orders");

        migrationBuilder.RenameColumn(
            name: "ShippingAddress_EmailAddress",
            table: "Orders",
            newName: "ShippingAddress_EmailName");

        migrationBuilder.RenameColumn(
            name: "Payment_CardName",
            table: "Orders",
            newName: "BillingAddress_EmailName");
    }
}
