using System.Runtime.CompilerServices;

public class Luigi {

// voor elke hamer moet ik een variabel aanmaken
    public FireHammer fireHammer;

    public Hammer hammer;

    public IceHammer iceHammer;

    public void SmashEnemyWithHammer(){
        if(hammer != null){
            hammer.SmashEnemy();
        }
    }

    //voor elke hamer moet ik een aparte methode maken
    public void SmashEnemyWithIceHammer(){
        if(iceHammer != null){
            iceHammer.SmashEnemy();
        }
    }


    public void SmashEnemyWithFireHammer(){
        if(fireHammer != null){
            fireHammer.SmashEnemy();
        }
    }
}