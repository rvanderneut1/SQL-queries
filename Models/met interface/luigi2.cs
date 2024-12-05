public class luigi2{
// ik hoef maar 1 variabel met de interface te maken
// Daar kan ik allen wapens die IHammer implementeren inzetten. 
    public IHammer hammer;

// ik hoef ook maar 1 methode aan te maken omdat ik weet dat een klasse die Ihammer implementeert de
// methode SmashEnemy moet hebben.
    public void SmashEnemy(){
        if(hammer != null){
            hammer.SmashEnemy();
        }
    }
}