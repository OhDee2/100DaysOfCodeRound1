using Microsoft.EntityFrameworkCore.Migrations;

namespace KingdomOfRelationships.Migrations
{
    public partial class AlterCharRelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "CharacterRelationship",
                newName: "ParentCharacterId");

            migrationBuilder.AddColumn<int>(
                name: "ChildCharacterId",
                table: "CharacterRelationship",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildCharacterId",
                table: "CharacterRelationship");

            migrationBuilder.RenameColumn(
                name: "ParentCharacterId",
                table: "CharacterRelationship",
                newName: "CharacterId");
        }
    }
}
