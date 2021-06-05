using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStorage : MonoBehaviour
{
    public string[] arr = new string[179];

    // Start is called before the first frame update
    void Start()
    {
        //verbascum/courage
        arr[0] = "> Verbascum. Native to Europe and Asia. Used in herbal medicine.";
        arr[1] = "> Amelias favorite flower";
        arr[2] = "> In the midst of wild things, we make our home."; //enter scene
        arr[3] = "> I see Grandma planting something in the ground in the backyard of our new home.";
        arr[4] = "> All around us the forest wild spreads over the backyard.";
        arr[5] = "> She kneels by the only small patch of clear dirt in the yard.";
        arr[6] = "Jay: Grandma? What are you doing?";
        arr[7] = "Grandma: A little house warming gift to get us started.";
        arr[8] = "Jay: Someone gave you that?";
        arr[9] = "Grandma: No, I bought it. But someone gave me the idea, long ago.";
        arr[10] = "Jay: Who? Grandpa?";
        arr[11] = "> Grandma pats the ground and I listen.";
        arr[12] = "Grandma: I used to be a dancer.";
        arr[13] = "> I see Amelia backstage, peering out from behind a curtain.";
        arr[14] = "> Ivy glides across the stage like a swan, fluid and graceful.";
        arr[15] = "> They stop, froxen in a perfect moment, their back to the croud but their eyes looking at Amelia.";
        arr[16] = "> A violin stretches a high note and stops singing, echoing in the air of a silent theater holding its breath.";
        arr[17] = "> Then, Ivy breaks the tension with a bow. She is bathed in applause and golden light.";
        arr[18] = "> Amelia smiles.";
        arr[19] = "> I've never seen her smile like that.";
        arr[20] = "> As Ivy walks toward Amelia, she smiles.";
        arr[21] = "Ivy: Break a leg!";
        arr[22] = "> Amelia looks at the empty stage.";
        arr[23] = "> The symphony picks up their instruments. The crowd settles down. The lights dim.";
        arr[24] = "> Two other performers stand next to Amlia, hands on each other's shoulders.";
        arr[25] = "> Amelia swallows, and walks out.";
        arr[26] = "> Her movements are clumsy and strained. How do you compete with perfection?";
        arr[27] = "> Amelia's dance is a duck's first walk compared to Ivy's flight across the stage.";
        arr[28] = "> Amelia moves to leap across the stage, a paltry tribute to Ivy's stride.";
        arr[29] = "> But she trips, and the trio stops.";
        arr[30] = "> One of the other performers offers to help Amelia up, but she storms out.";
        arr[31] = "> The curtains swallow Amelia as she walks back to the dressing room";
        arr[32] = "> She slams the dressing room door and crashes into a seat.";
        arr[33] = "> Only tears and sobs come out as she tries to wring the memory of the dance from her head.";
        arr[34] = "> She kicks a bouquet of flowers off the table and it collapses in a vibrant splash across the floor.";
        arr[35] = "> Ivy enters to room";
        arr[36] = "Ivy: Are you ok?";
        arr[37] = "Amelia: I've been better.";
        arr[38] = "Ivy: I know.";
        arr[39] = "> Amelia frowns and turns away.";
        arr[40] = "Amelia: I want to be alone.";
        arr[41] = "> Ivy plucks a flower from the fallen bouquet- a verbascum.";
        arr[42] = "Ivy: This is a verbascum. You know what it's used for?";
        arr[43] = "Amelia: No, what?";
        arr[44] = "Ivy: people use them to make tea. They say it heals wounds.";
        arr[45] = "Amelia: Have you ever tried it?";
        arr[46] = "Ivy: No, but... I'm sure it couldn't hurt.";
        arr[47] = "> Ivy gives the flower to Amelia, who looks at the petals and smiles.";
        arr[48] = "Amelia: Sounds like snake oil.";
        arr[49] = "Ivy: It's just something people say about the flower.";
        arr[50] = "Amelia: Are you trying to pass off hokey folk medicine to make me feel better?";
        arr[51] = "Ivy: Is it working?";
        arr[52] = "> Ivy places her hand on Amelia's hand.";
        arr[53] = "> At once, her thoughts calm into a warm color, like milk tea.";
        arr[54] = "> Later, Amelia walks out of the theater in a coat.";
        arr[55] = "> Granspa is waiting and takes her by the arm.";
        arr[56] = "Grandpa: Did you get my flowers?";
        arr[57] = "Amelia: They were lovely."; //end scene
        //Allium/strength/day
        arr[58] = "> Allium. Native to the Northern Hemisphere, but grown all over the world.";
        arr[59] = "> Latin for garlic. Tastes like garlic.";
        arr[60] = "> I can smell the green. The soil is caked in between my toes."; // Begin scene
        arr[61] = "> I step between rows and rows of flowers, our little pasture.";
        arr[62] = "> All day, the sun has been beating down on my shoulders as I clip leaves and plant new flowers and tear out weeds.";
        arr[63] = "> Grandma's been making me play gardener ever since her hands couldn't even hold a spade.";
        arr[64] = "> But she still wants the garden to be tended.";
        arr[65] = "> She watches from the awning shade as I walk back and forth, sweat stick over my body like a wet glove.";
        arr[66] = "Amelia: Now the allium! C'mon, just these alliums and then you can go inside.";
        arr[67] = "Jay: Yes, Grandma";
        arr[68] = "> Finally, I scoop a couple potted alliums and walk over to a free row.";
        arr[69] = "> I think about the warm shower that awaits me, and then wonder about whether Megan Boyle updated her Liveblog.";
        arr[70] = "> But before I know it, my foot snags on a root and the alliums slip from my hands.";
        arr[71] = "> They smash against the earth in a heap of bent plastic and soil and smothered green.";
        arr[72] = "Amelia: You're just like your grandpa. So clumsy!";
        arr[73] = "Jay: I'll be more careful.";
        arr[74] = "Amelia: If you jsut watched where you were going and stopped being lost in your daydreams...";
        arr[75] = "Jay: Well I would if you were more patient with me!";
        arr[76] = "> We stand in silence.";
        arr[77] = "> Then, Grandma shakes her head and continues fanning her face with my New York Magazine.";
        arr[78] = "> I wiggle my toes in the dirt.";
        arr[79] = "Amelia: Go plant that over there.";
        arr[80] = "> I scoop up the alliums and walk over to their row.";
        arr[81] = "Amelia: If you jsut wore shoes you would stop tripping over everything. That's the second time you almost killed my flowers today.";
        arr[82] = "Jay: You can always buy more flowers Grandma.";
        arr[83] = "Jay: Oh, wait, I have to buy them. Since your hands stopped working.";
        arr[84] = "Amelia: My hands are fine. They're what you get when you spend a lifetime doing good work.";
        arr[85] = "> I set the alliums down. With a spade, I start tearing out a hole in the earth.";
        arr[86] = "Jay: I don't see why we keep planting these fowers if they're just gonna die.";
        arr[87] = "> Amelia stops and steps out from the shade.";
        arr[88] = "> I think she's going to yell at me or tell me to shut my mouth, but shes just stands there.";
        arr[89] = "> I can't quite make out her face; not angry, not sad, just... still";
        arr[90] = "> After a moment, she turns and walks inside te house.";
        arr[91] = "> I could go after her, but looking down, I see the alliums and the ragged hole I was digging.";
        arr[92] = "> With practiced effort, I take the alliums and, one by one, plant them down.";
        arr[93] = "They're a little hunched over, like stubborn children.";
        arr[94] = "I lift a stem with my finger but it droops back down when I move my hand away.";
        arr[95] = "Jay: Shit.";
        arr[96] = "> I walk into the house barefoot. Earthy footsteps lead back to the garden as I walk into the living room.";
        arr[97] = "> Amelia sits ont he couch. not crying ot anything... just quiet.";
        arr[98] = "> I'm not quite sure what to say. I could say sorry, maybe apologize for being such a-";
        arr[99] = "Amelia: You're tracking dirt on ym carpet.";
        arr[100] = "Jay: I'll clean it up.";
        arr[101] = "> Amelia nods, but not at me, like she's dreamwalking somewhere else.";
        arr[102] = "Amelia: When your grandpa passed, I didn't cry.";
        arr[103] = "Jay: We didn't really visit him.";
        arr[104] = "Amelia: There wasn't much to see.";
        arr[105] = "Amelia: For the passed three years he was an old man living on his deathbed. You're uncle never forfave me for not visiting.";
        arr[106] = "Jay: At least I don't have to eat his meatloaf at Christmas anymore.";
        arr[107] = "> Amelia snorts. I think that snapped her back.";
        arr[108] = "Amelia: He never trusted Ivy.";
        arr[109] = "Jay: Uncle?";
        arr[110] = "Amelia: No, Hollis. Your abuelo.";
        arr[111] = "Jay: Why didn't he like Ivy?";
        arr[112] = "Amelia: He thought she and I had a close relationship, closer than our marriage.";
        arr[113] = "Jay: Was he right?";
        arr[114] = "> She lokos away, and the looks back at me.";
        arr[115] = "Amelia: I used to hide my letters from her when your grandpa got home. What do yout think?";//end scene
        //Coral Bells/Everlasting Love/ Over cast
        arr[116] = "> Coral Bells. Native to North America. Very low maintanance plant that doesn't need sunlight.";
        arr[117] = "> It's six PM. I'm washing my hands in the kitchen sink and looking out tot he garden";//beging scene
        arr[118] = "> It's overflowing like something out of a gardening magazine. I'm kind of impressed with myself.";
        arr[119] = "> Grandma doesn't even watch me work anymore. I walk into the living room to see if she wants something to eat.";
        arr[120] = "> Suddenly, I hear Grandma yell. She runs past me from out of her room toward the garden";
        arr[121] = "> I see her kneel down and start pulling out flowers like weeds in a frantic fury.";
        arr[122] = "> Crying, screaming, a wild frightened animal.";
        arr[123] = "Jay: Grandma! What are you doing?!";
        arr[124] = "> I run over and hold her. She crumples in my arms, like all the fight in her suddenly evaporated the moment I touched her.";
        arr[125] = "> We sit down in the dirt together among the ripped out flowers.";
        arr[126] = "> Grandma puts her face against me and lets out waves of heavy sobs, each one adding to the dampness of my chest";
        arr[127] = "> It's like a storm finally breaking after a long quiet, like she's been holding it in her entire life.";
        arr[128] = "Jay: Okay Grandma, it's.... it's alright. What's gotten into you?";
        arr[129] = "Amelia: She's gone.";
        arr[130] = "Jay: Who?";
        arr[131] = "Amelia: Ivy. Her nieta called and... I don't know. I just...";
        arr[132] = "> I pat Grandma's back and we sit in the quiet of our garden.";
        arr[133] = "> Christmas Eve, four years ago. I'm in my Grandpa's house in California.";
        arr[134] = "> The air is hot and muggy, just like Christmas in July,";
        arr[135] = "> only people decorate their houses in snowmen and candy canes, like these trinkets could summon snowy weather.";
        arr[136] = "> I'm still in high school.";
        arr[137] = "> I'm stuffing my bedroom door with a towel to hide the weed smell, but I'm paranoid it's on my breath.";
        arr[138] = "> Even with the window open and my desk fan on, it doesn't seem to go away.";
        arr[139] = "Shit.";
        arr[40] = "I hear my family's voices seeping through the door.";
        arr[141] = "They come and go in spurts of laughter and I think that maybe I should just stay and starve.";
        arr[142] = "> I take out my journal and start to write down how I'm tinking when someone knocks on the door.";
        arr[143] = "Grandpa: Jay? You coming out? Dinner's ready.";
        arr[144] = "Jay: Yeah, just give me a sec.";
        arr[145] = "> I pull the towel from the floor and step out.";
        arr[146] = "> As the door opens I feel the gust blow out into the hallway, betraying me.";
        arr[147] = "> Grandpa looks me up and down and sighs.";
        arr[148] = "Grandpa: Come on.";
        arr[149] = "> Into the dining room, I walk and see my aunts standing around the table talking.";
        arr[150] = "> A huge spread of food stretches from end to end, wich barely any room fo plates.";
        arr[151] = "> In the corner I see Amelia talking to her friend, Ivy. They seem to be in their own bubble";
        arr[152] = "> Whenever Ivy talks, Amelia laughs.";
        arr[153] = "> She touches Ivy's shoulder as if to punctaute every laugh,";
        arr[154] = "> which is weird because I've never seen Amelia touch anyone like that.";
        arr[155] = "Granpa: What did Amelia tell you about her?";
        arr[156] = "Jay: Nothing, she's just an old friend";
        arr[157] = "Grandpa: They used to dance together. But she lives far away. And she won't be coming bacl, if I can help it.";
        arr[158] = "Jay: Not coming back? What do you mean?";
        arr[159] = "> As he says that, my uncle brings out a meatloaf from the kitchen.";
        arr[160] = "Uncle: Come everyone! Get it while it's hot!";
        arr[161] = "> Everyone sits down, kids on one end and adults on the other.";
        arr[162] = "> I sit in the middle, near my aunts, who are all three years older than me,";
        arr[163] = "> and already on their second or third kid.";
        arr[164] = "Grandpa: Now that we're all here, let's start with prayer.";
        arr[165] = "> Everyone looks at me. I look around telepathically screaming: ";
        arr[166] = "> 'You want the stoned kid to say a prayer?!'";
        arr[167] = "> But then we all take each other's hands,";
        arr[168] = "> and I pull some deep stuff from the back of my head and pass it off as prayer.";
        arr[169] = "> As I'm babbling on, I swear, from the corner of my eye, I could see Amelia and Ivy.";
        arr[170] = "> They're not looking at each other, but I could see them, heads bowed, holding hands, smiling.";
        arr[171] = "> As if they are always like that. Always together.";
        //flavor text
        arr[172] = "> Expensive, but worth it. Guess I won't eat dinner for the next two weeks";
        arr[173] = "> In front of my salad?!";
        arr[174] = "> HIM.";
        //ipomae
        arr[175] = "> Ipomoea. Native to Central America.";
        arr[176] = "> Used to symbolize mortality.";
        arr[177] = "> ...";
        arr[178] = "> I guess I have to go plant these now...";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
