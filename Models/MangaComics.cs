
public class MangaComics 
{
    public int id;

    public string name;

    public int volume;

    public bool isRead;

    public MangaComics(int id, string name, int volume, bool isRead){
        //this staat betekend deze klasse daarom kan ik van hieruit id zetten.
        this.id = id;
        this.name = name;
        this.volume = volume;
        this.isRead = isRead;
    }

    public string Output(){
        return $"{id}, {name}, {volume}, {isRead}";
    }


}