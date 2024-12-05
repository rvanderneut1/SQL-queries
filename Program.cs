// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

var Sqlrepository = new SQLRepository();

var results = Sqlrepository.SelectMangaComics();

foreach(MangaComics manga in results){
    Console.WriteLine(manga.Output());
}

var luigi = new Luigi();

luigi.fireHammer = new FireHammer();
luigi.SmashEnemyWithHammer(); // geen output
luigi.SmashEnemyWithFireHammer(); // wel output
luigi.fireHammer = null;
luigi.iceHammer = new IceHammer();
luigi.SmashEnemyWithIceHammer();


var luigi2 = new luigi2();
luigi2.hammer = new IceHammer1();
luigi2.SmashEnemy();
luigi2.hammer = new Hammer1();
luigi2.SmashEnemy();
luigi2.hammer = null;
luigi2.SmashEnemy();
