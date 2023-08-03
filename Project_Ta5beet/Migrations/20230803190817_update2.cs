using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Ta5beet.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTrainer_Gyms_GymID",
                table: "GymTrainer");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTrainer_Trainers_TrainerID",
                table: "GymTrainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GymTrainer",
                table: "GymTrainer");

            migrationBuilder.RenameTable(
                name: "GymTrainer",
                newName: "GymTrainers");

            migrationBuilder.RenameIndex(
                name: "IX_GymTrainer_GymID",
                table: "GymTrainers",
                newName: "IX_GymTrainers_GymID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GymTrainers",
                table: "GymTrainers",
                columns: new[] { "TrainerID", "GymID" });

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrainers_Gyms_GymID",
                table: "GymTrainers",
                column: "GymID",
                principalTable: "Gyms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrainers_Trainers_TrainerID",
                table: "GymTrainers",
                column: "TrainerID",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymTrainers_Gyms_GymID",
                table: "GymTrainers");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTrainers_Trainers_TrainerID",
                table: "GymTrainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GymTrainers",
                table: "GymTrainers");

            migrationBuilder.RenameTable(
                name: "GymTrainers",
                newName: "GymTrainer");

            migrationBuilder.RenameIndex(
                name: "IX_GymTrainers_GymID",
                table: "GymTrainer",
                newName: "IX_GymTrainer_GymID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GymTrainer",
                table: "GymTrainer",
                columns: new[] { "TrainerID", "GymID" });

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrainer_Gyms_GymID",
                table: "GymTrainer",
                column: "GymID",
                principalTable: "Gyms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrainer_Trainers_TrainerID",
                table: "GymTrainer",
                column: "TrainerID",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
