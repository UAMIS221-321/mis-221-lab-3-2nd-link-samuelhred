//Start Main
DisplayEnjoymentOptions();
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendations(enjoymentLevel);
string game = GetGameRecommendations(stadium);
DisplayStadiumDetails(stadium,game);



//End
static void DisplayEnjoymentOptions(){
    System.Console.WriteLine("Choose from the following options: \n Boring \n Average \n Fun \n Epic");

}

static string GetEnjoymentLevel(){
    string enjoy = System.Console.ReadLine();
    return(enjoy);

}
static string GetStadiumRecommendations(string enjoymentLevel){
    switch(enjoymentLevel){
        case "Boring":
            return("Neyland Stadium");
            break;
        case "Average":
            return("Jordan-Haire Stadium");
            break;
        case "Fun":
            return("Tiger Stadium");
            break;
        case "Epic":
            return("Saban Field at Bryant-Denny Stadium");
            break;
        default:
            return("");
            break;

    }

}

static string GetGameRecommendations(string stadium){
    switch(stadium){
        case "Neyland Stadium":
            return("vs Kent State");
            break;
        case "Jordan-Haire Stadium":
            return("vs Kentucky");
            break;
        case "Tiger Stadium":
            return("vs Alabama");
            break;
        case "Saban Field at Bryant-Denny Stadium":
            return("vs Auburn");
            break;
        default:
            return("");
            break;

    }

}

static void DisplayStadiumDetails(string stadium, string game){
    if(stadium == ""){
        System.Console.WriteLine("Your Enjoyment Choice was invalid.");
    }
    else{
        System.Console.WriteLine("You should go to " + stadium + "\n" + game);

    }

}

