using Microsoft.EntityFrameworkCore.Migrations;

namespace KingdomOfRelationships.Migrations
{
    public partial class AddProperForeignKeyStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "CharacterRelationship",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ParentCharacterId",
                table: "CharacterRelationship",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ChildCharacterId",
                table: "CharacterRelationship",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRelationship_ChildCharacterId",
                table: "CharacterRelationship",
                column: "ChildCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRelationship_ParentCharacterId",
                table: "CharacterRelationship",
                column: "ParentCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRelationship_RelationshipId",
                table: "CharacterRelationship",
                column: "RelationshipId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterRelationship_Characters_ChildCharacterId",
                table: "CharacterRelationship",
                column: "ChildCharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterRelationship_Characters_ParentCharacterId",
                table: "CharacterRelationship",
                column: "ParentCharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterRelationship_Relationships_RelationshipId",
                table: "CharacterRelationship",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "RelationshipId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterRelationship_Characters_ChildCharacterId",
                table: "CharacterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterRelationship_Characters_ParentCharacterId",
                table: "CharacterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterRelationship_Relationships_RelationshipId",
                table: "CharacterRelationship");

            migrationBuilder.DropIndex(
                name: "IX_CharacterRelationship_ChildCharacterId",
                table: "CharacterRelationship");

            migrationBuilder.DropIndex(
                name: "IX_CharacterRelationship_ParentCharacterId",
                table: "CharacterRelationship");

            migrationBuilder.DropIndex(
                name: "IX_CharacterRelationship_RelationshipId",
                table: "CharacterRelationship");

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "CharacterRelationship",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentCharacterId",
                table: "CharacterRelationship",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChildCharacterId",
                table: "CharacterRelationship",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
