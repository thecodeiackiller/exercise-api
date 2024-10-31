﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exercise_api.ExerciseContext;

#nullable disable

namespace exercise_api.Migrations
{
    [DbContext(typeof(ExerciseDbContext))]
    partial class ExerciseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exercise_api.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkoutType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A pulling exercise targeting the biceps and back muscles, pulling the body up to a bar with palms facing towards you.",
                            ExerciseType = "Core",
                            Name = "Chin Ups",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A pulling exercise targeting the upper back and biceps, often performed on a bar or with a suspension trainer.",
                            ExerciseType = "Core",
                            Name = "Backups",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 3,
                            Description = "An isolation exercise focusing on the biceps, performed by curling a barbell towards the shoulders.",
                            ExerciseType = "Core",
                            Name = "Barbell Curls",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A shoulder press variation that targets the shoulders and upper back, pressing a barbell behind the head.",
                            ExerciseType = "Core",
                            Name = "Behind Head Overhead Barbell Press",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A twisting movement using a landmine attachment to engage the core while pushing the weight forward.",
                            ExerciseType = "Core",
                            Name = "Landmine Twist Push",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A rotational movement with a landmine that targets the core and back muscles while pulling the weight.",
                            ExerciseType = "Core",
                            Name = "Landmine Pull Rotation",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A core exercise using a landmine to rotate the body, engaging the obliques and stabilizing muscles.",
                            ExerciseType = "Core",
                            Name = "Landmine Rotations",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 8,
                            Description = "A squat variation performed with a barbell held overhead, targeting the entire body and requiring core stability.",
                            ExerciseType = "Core",
                            Name = "Overhead Squats",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 9,
                            Description = "A dynamic movement targeting the quadriceps, glutes, and hamstrings by stepping forward into a lunge position.",
                            ExerciseType = "Core",
                            Name = "Front Lunges",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 10,
                            Description = "A lateral movement that engages the inner and outer thighs by stepping to the side into a lunge position.",
                            ExerciseType = "Core",
                            Name = "Side Lunges",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 11,
                            Description = "An exercise that targets the glutes and lower back, performed by lifting the hips off the ground while lying down.",
                            ExerciseType = "Accessory",
                            Name = "Hip Ups",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 12,
                            Description = "An isolation exercise focusing on the calves, performed by raising the heels off the ground while standing.",
                            ExerciseType = "Secondary",
                            Name = "Calf Raises",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 13,
                            Description = "A lateral leg lift targeting the hip abductors and glutes, performed by kicking the leg to the side.",
                            ExerciseType = "Accessory",
                            Name = "Sidekicks",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 14,
                            Description = "An exercise that engages the shoulders and core while rotating a resistance band overhead.",
                            ExerciseType = "Accessory",
                            Name = "Banded Overhead Rotations",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 15,
                            Description = "A variation of overhead rotations performed with a reverse grip to target different shoulder muscles.",
                            ExerciseType = "Accessory",
                            Name = "Reverse Grip Banded Overhead Rotations",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 16,
                            Description = "An exercise targeting the upper back and shoulders by pulling a resistance band towards the chest with palms down.",
                            ExerciseType = "Accessory",
                            Name = "Front Palm Down Banded Pulls",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 17,
                            Description = "A pulling exercise targeting the upper back and biceps, performed with palms facing up on a resistance band.",
                            ExerciseType = "Accessory",
                            Name = "Banded Palm Up Banded Pulls",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 18,
                            Description = "A pulling exercise targeting the upper back, performed with a resistance band with palms facing down.",
                            ExerciseType = "Accessory",
                            Name = "Back Banded Palm Down Pulls",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 19,
                            Description = "A pulling exercise targeting the upper back, performed with a resistance band with palms facing up.",
                            ExerciseType = "Accessory",
                            Name = "Back Banded Palm Up Pulls",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 20,
                            Description = "A core and shoulder stability exercise performed by extending arms and legs while lying face down.",
                            ExerciseType = "Accessory",
                            Name = "Swimmers",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 21,
                            Description = "A compound upper body exercise.",
                            ExerciseType = "Core",
                            Name = "Bench Press",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 22,
                            Description = "A shoulder press exercise.",
                            ExerciseType = "Core",
                            Name = "Overhead Press",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 23,
                            Description = "Bodyweight exercise for upper body.",
                            ExerciseType = "Core",
                            Name = "Pull-Ups",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 24,
                            Description = "Upper back exercise.",
                            ExerciseType = "Secondary",
                            Name = "Dumbbell Rows",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 25,
                            Description = "Variation of bench press.",
                            ExerciseType = "Secondary",
                            Name = "Incline Bench Press",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 26,
                            Description = "Triceps-focused bodyweight exercise.",
                            ExerciseType = "Secondary",
                            Name = "Dips",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 27,
                            Description = "Shoulder isolation exercise.",
                            ExerciseType = "Accessory",
                            Name = "Lateral Raises",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 28,
                            Description = "Triceps isolation exercise.",
                            ExerciseType = "Accessory",
                            Name = "Tricep Pushdowns",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 29,
                            Description = "Biceps isolation exercise.",
                            ExerciseType = "Accessory",
                            Name = "Bicep Curls",
                            WorkoutType = "UpperBodyStrength"
                        },
                        new
                        {
                            Id = 30,
                            Description = "A compound lower body exercise.",
                            ExerciseType = "Core",
                            Name = "Squat",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 31,
                            Description = "A compound lift for posterior chain.",
                            ExerciseType = "Core",
                            Name = "Deadlift",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 32,
                            Description = "Lower body machine-based exercise.",
                            ExerciseType = "Core",
                            Name = "Leg Press",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 33,
                            Description = "Single-leg exercise.",
                            ExerciseType = "Secondary",
                            Name = "Bulgarian Split Squat",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 34,
                            Description = "Hamstring-targeted exercise.",
                            ExerciseType = "Secondary",
                            Name = "Romanian Deadlift",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 35,
                            Description = "Lower body exercise with step.",
                            ExerciseType = "Secondary",
                            Name = "Step-Ups",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 36,
                            Description = "Machine-based hamstring exercise.",
                            ExerciseType = "Accessory",
                            Name = "Hamstring Curls",
                            WorkoutType = "LowerBodyStrength"
                        },
                        new
                        {
                            Id = 37,
                            Description = "Glute-focused exercise.",
                            ExerciseType = "Accessory",
                            Name = "Glute Bridges",
                            WorkoutType = "LowerBodyStrength"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
