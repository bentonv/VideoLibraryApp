using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibraryBusinessLayer
{
    public static class VideoFactory
    {
        public static Collection<Video> GetCollection()
        {
            Video v = null;
            var result = new Collection<Video>();
            v = new Video() { VideoId = 1, Title = "The Godfather: Part II", Year = 1974, Director = "Francis Ford Coppola", Rating = 5 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "I really enjoyed this movie" });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMjZiNzIxNTQtNDc5Zi00YWY1LThkMTctMDgzYjY4YjI1YmQyL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,702,1000_AL_.jpg";
            v.Plot = @"The early life and career of Vito Corleone in 1920s New York is portrayed while his son, Michael, expands and tightens his grip on the family crime syndicate.";
            result.Add(v);

            v = new Video() { VideoId = 2, Title = "Taxi Driver", Year = 1976, Director = "Martin Scorsese", Rating = 5 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "This movie has changed my life!!" });
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "This is a good movie, recommended." });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNGQxNDgzZWQtZTNjNi00M2RkLWExZmEtNmE1NjEyZDEwMzA5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,654,1000_AL_.jpg";
            v.Plot = @"A mentally unstable Vietnam War veteran works as a night-time taxi driver in New York City where the perceived decadence and sleaze feeds his urge for violent action, while attempting to save a preadolescent prostitute in the process.";
            result.Add(v);

            v = new Video() { VideoId = 3, Title = "The Deer Hunter", Year = 1978, Director = "Michale Cimino", Rating = 5 }; 
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "However as many film historians, authors and critics have already pointed out, the film is never meant to be a 100% accurate depiction of the events in Vietnam. It is not really a Vietnam War picture at all. Instead, it is a focus on the aftermath of war, and how damaging it can be, both physically and mentally, to its participants. Because of the era that \"The Deer Hunter\" was released in, Vietnam was a recent event, the focus of the nation, and is therefore used as a more convenient -- and relative -- backdrop (much like \"Apocalypse Now\"). Unlike \"Platoon\" this is not a movie relating specifically to the Vietnam War, in fact less than a half an hour is devoted to the war scenes. It is a character study, and accusations of racism -- although perhaps justified to some extent -- are hardly convincing as the film itself is not concerned with bashing the participants of the war as it is the war itself." });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNjMxZWIyYzQtNjYzNy00NTk1LTg3ZDEtZDRmZmMxYmY4YmVjXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,678,1000_AL_.jpg";
            v.Plot = @"An in-depth examination of the ways in which the U.S. Vietnam War impacts and disrupts the lives of people in a small industrial town in Pennsylvania.";
            result.Add(v);

            v = new Video() { VideoId = 4, Title = "Raging Bull", Year = 1980, Director = "Martin Scorsese", Rating = 5 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "What an amazing film!" });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNDg1YTFlMDgtNzNhNy00ODhlLWFhMTAtOTE5MjhjNzI0NDljXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SY1000_CR0,0,668,1000_AL_.jpg";
            v.Plot = @"An emotionally self-destructive boxer's journey through life, as the violence and temper that leads him to the top in the ring destroys his life outside it.";
            result.Add(v);

            v = new Video() { VideoId = 5, Title = "Falling in Love", Year = 1984, Director = "Ulu Grosbard", Rating = 3 };
            v.PosterUrl = @"";
            v.Plot = @"During shopping for Christmas, Frank and Molly run into each other. This fleeting short moment will start to change their lives, when they recognize each other months later in the train home and have a good time together. Although both are married and Frank has two little kids, they meet more and more often, their friendship becoming the most precious thing in their lives.";
            result.Add(v);

            v = new Video() { VideoId = 6, Title = "Angel Heart", Year = 1987, Director = "Alan Parker", Rating = 5 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BYmUxNDMyOGQtNTQ1MS00NzhiLWE5ZDUtZGFmMDcyODVmYzU5XkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_.jpg";
            v.Plot = @"Harry Angel is a private investigator. He is hired by a man who calls himself Louis Cyphre to track down a singer called Johnny Favorite. But the investigation takes an unexpected and somber turn.";
            result.Add(v);

            v = new Video() { VideoId = 7, Title = "Midnight Run", Year = 1988, Director = "Martin Brest", Rating = 4 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "You should watch the Midnight Run!" });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BZGIwM2JhNmQtYzQ5ZC00NzdkLTgwZjItMDRiN2QxM2ViMzk0XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_SY1000_CR0,0,655,1000_AL_.jpg";
            v.Plot = @"An accountant is chased by bounty hunters, the FBI, and the Mafia after jumping bail.";
            result.Add(v);

            v = new Video() { VideoId = 8, Title = "The Untouchables", Year = 1987, Director = "Brian De Palma", Rating = 2 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "This film is a classic gangster movie with an excellent cast. Sean Connery is a standout and clearly deserved the Oscar nod. Andy Garcia, Kevin Costner (Field of Dreams) and Charles Martin Smith draw the viewer into the world of good men taking great personal risk in standing up to corruption in Chicago. Not enough to warrant your attention? How about De Niro (The Good Shepard) as Al Capone? This film has a great director in Brian De Palma guiding us along through an interesting script. By the way, you might not know that De Niro actually tracked down Copones tailors to make his suits. DeNiro deserved and Oscar too. If you like crime thrillers, then you will love this film. The Dark Knight reminded me of this film in some aspects." });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BYTVjYWJmMWQtYWU4Ni00MWY3LWI2YmMtNTI5MDE0MWVmMmEzL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,646,1000_AL_.jpg";
            v.Plot = @"Federal Agent Eliot Ness sets out to stop Al Capone; because of rampant corruption, he assembles a small, hand-picked team.";
            result.Add(v);

            v = new Video() { VideoId = 9, Title = "GoodFellas", Year = 1990, Director = "Martin Scorsese", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNThjMzczMjctZmIwOC00NTQ4LWJhZWItZDdhNTk5ZTdiMWFlXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SY1000_CR0,0,669,1000_AL_.jpg";
            v.Plot = @"The story of Henry Hill and his life through the teen years into the years of mafia, covering his relationship with wife Karen Hill and his Mob partners Jimmy Conway and Tommy DeVitto in the Italian-American crime syndicate.";
            result.Add(v);

            v = new Video() { VideoId = 10, Title = "Backdraft", Year = 1991, Director = "Ron Howard", Rating = 3 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "Ron Howard did a wonderful job of bringing some of the real-life problems that firefighters face everyday in Backdraft. I'm kind of tired of hearing the Monday morning quarterbacks on this site trying to talk about how bad it was and that it wasn't realistic, etc. Take it from a REAL firefighter who has lost brothers in REAL fires and has lived through a REAL backdraft, it's NOT all fun and games, and it's far from glamourous. This movie did an excellent job capturing some of the emotions that flow through every firehouse in America today, particularly after 9/11, we are a brotherhood in which the \"I go---we go\" mentality is a very REAL concept that most of us live by everyday." });
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "This is one of Ron Howard's better films. Much of the filming was done on location in Chicago. Acting was excellent. Especially by Kurt Russell and William Baldwin. I have heard a lot of negatives about this movie, but I still feel it is worth a 9 at least. Steven and Brian McCaffery's dad (also a fireman) was killed in a fire in 1971. Brian was just a youngster, and along for the ride with his dad when he was killed. Twenty years later, Brian has become a fireman after failing at other pursuits. Steven is a lieutenant with the Chicago Fire Department. Steven does not think Brian can cut the mustard as a fireman, and Brian is out to prove himself. It makes for a great sibling rivalry. On top of this, an arsonist is setting fires, and the arson investigator, Donald Rimgale (Robert DeNero) does not have a clue as to who it is. Rimgale is pressured by an egotistical alderman (J.T. Walsh) who wants to be mayor. Brian has his problems working with Steven, and finally gives up, and accepts a job working with Rimgale. They find the links between all the fires, but Brian finds out more. (who the arsonist is). The climactic scene in chemical warehouse is great! I was told by someone that the funeral scene was overdone. I don't think so...I have seen funerals for firemen and they look exactly like what you see in the movie...Universal Studios in Hollywood had a Backdraft set on their lot some years back (which I visited), and it gives you a chance to see what these actors really faced...This is without a doubt one of my favorite movies, and Ron Howard deserves his share of kudos for an excellent directing job" });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BZTFjOWVkNjUtYTdkOC00MGQ5LWI5OTQtMTIyYzQwN2UzMDgzXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SY1000_SX674_AL_.jpg";
            v.Plot = @"Two Chicago firefighter brothers who don't get along have to work together while a dangerous arsonist is on the loose.";
            result.Add(v);

            v = new Video() { VideoId = 11, Title = "Mad Dog and Glory", Year = 1993, Director = "John McNaughton", Rating = 2 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc1OTc0NDQyNF5BMl5BanBnXkFtZTcwMTEzNDQyMQ@@._V1_.jpg";
            v.Plot = @"After his life is saved by a lonely cop, a mobster who moonlights as a stand-up comedian provides the cop with a beautiful young companion.";
            result.Add(v);

            v = new Video() { VideoId = 12, Title = "A Bronx Tale", Year = 1993, Director = "Robert De Niro", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTg2MTg5MTY0M15BMl5BanBnXkFtZTgwMjA5MDgxMTE@._V1_.jpg";
            v.Plot = @"A father becomes worried when a local gangster befriends his son in the Bronx in the 1960s.";
            result.Add(v);

            v = new Video() { VideoId = 13, Title = "Mary Shelley's Frankenstein", Year = 1994, Director = "Kenneth Branagh", Rating = 1 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMDY3ZjIyOGMtZjI3YS00YTUxLTg4YjAtODhjNWM1Nzk4MDE3XkEyXkFqcGdeQXVyNjE5MjUyOTM@._V1_.jpg";
            v.Plot = @"When the brilliant but unorthodox scientist Victor Frankenstein rejects the artificial man that he has created, the Creature escapes and later swears revenge.";
            result.Add(v);

            v = new Video() { VideoId = 14, Title = "Casino", Year = 1995, Director = "Martin Scorsese", Rating = 5 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "Great movie about Las Vegas in the 1970s and '80s." });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTcxOWYzNDYtYmM4YS00N2NkLTk0NTAtNjg1ODgwZjAxYzI3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SY1000_CR0,0,666,1000_AL_.jpg";
            v.Plot = @"Greed, deception, money, power, and murder occur between two best friends: a mafia underboss and a casino owner, for a trophy wife over a gambling empire.";
            result.Add(v);

            v = new Video() { VideoId = 15, Title = "Heat", Year = 1995, Director = "Michael Mann", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNGMwNzUwNjYtZWM5NS00YzMyLWI4NjAtNjM0ZDBiMzE1YWExXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_SY1000_CR0,0,678,1000_AL_.jpg";
            v.Plot = @"A group of professional bank robbers start to feel the heat from police when they unknowingly leave a clue at their latest heist, while both sides attempts to find balance their personal lives with their professional lives.";
            result.Add(v);

            v = new Video() { VideoId = 16, Title = "Sleepers", Year = 1996, Director = "Barry Levinson", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc4OTUzNzc0MV5BMl5BanBnXkFtZTgwMjE4ODYxMTE@._V1_.jpg";
            v.Plot = @"After a prank goes disastrously wrong, a group of boys are sent to a detention center where they are brutalized; over 10 years later, they get their chance for revenge.";
            result.Add(v);

            v = new Video() { VideoId = 17, Title = "Jackie Brown", Year = 1997, Director = "Quentin Tarantino", Rating = 5 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNmY5ODRmYTItNWU0Ni00MWE3LTgyYzUtYjZlN2Q5YTcyM2NmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,683,1000_AL_.jpg";
            v.Plot = @"A middle-aged woman finds herself in the middle of a huge conflict that will either make her a profit or cost her life.";
            result.Add(v);

            v = new Video() { VideoId = 18, Title = "Wag the Dog", Year = 1997, Director = "Barry Levinson", Rating = 5 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "The film is great fun and is loaded with talent.A great screenplay as expected from David Mamet and Hilary Henkin.At the helm is the wonderful Barry Levinson, and also lending their charms are Anne Heche, Denis Leary, Woody Harrelson, Willie Nelson,William H Macy, Craig T. Nelson and Kirsten Dunst." });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTk0NTEyNzEwMF5BMl5BanBnXkFtZTgwNjcwNTcxMTE@._V1_.jpg";
            v.Plot = @"Shortly before an election, a spin-doctor and a Hollywood producer join efforts to fabricate a war in order to cover up a presidential sex scandal.";
            result.Add(v);

            v = new Video() { VideoId = 19, Title = "Ronin", Year = 1998, Director = "John Frankenheimer", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BOWVkYzliZGEtODIxMi00MDQwLThjMDAtNzI3M2NjYjg4NDE5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,676,1000_AL_.jpg";
            v.Plot = @"A freelancing former U.S. intelligence agent tries to track down a mysterious package that is wanted by both the Irish and the Russians.";
            result.Add(v);

            v = new Video() { VideoId = 20, Title = "Great Expectations", Year = 1998, Director = "Alfonso Cuaron", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BOGY5Y2RjNDgtMjMyNi00ZWM5LTllNDMtM2JiYzM3ZjM2Mzg1XkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SY1000_CR0,0,676,1000_AL_.jpg";
            v.Plot = @"Modernization of Charles Dickens classic story finds the hapless Finn as a painter in New York pursuing his unrequited and haughty childhood love.";
            result.Add(v);

            v = new Video() { VideoId = 21, Title = "Analyze This", Year = 1999, Director = "Harold Ramis", Rating = 5 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNTIzNjQ5OTMtM2U2NS00YTNkLWIzMmYtOTcyOTA5MDU0YTdjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,666,1000_AL_.jpg";
            v.Plot = @"A comedy about a psychiatrist whose number one-patient is an insecure mob boss.";
            result.Add(v);

            v = new Video() { VideoId = 22, Title = "Meet the Parents", Year = 2000, Director = "Jay Roach", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMGNlMGZiMmUtZjU0NC00MWU4LWI0YTgtYzdlNGVhZGU4NWZlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_SX674_AL_.jpg";
            v.Plot = @"Male nurse Greg Focker meets his girlfriend's parents before proposing, but her suspicious father is every date's worst nightmare.";
            result.Add(v);

            v = new Video() { VideoId = 23, Title = "The Score", Year = 2001, Director = "Frank Oz", Rating = 5 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BZDNjYmY1ZDEtM2I3YS00MDhmLTk5NDYtYzU5MTA4ZjIyYzJiL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            v.Plot = @"An aging thief hopes to retire and live off his ill-gotten wealth when a young kid convinces him into doing one last heist.";
            result.Add(v);

            v = new Video() { VideoId = 24, Title = "Shark Tale", Year = 2004, Director = "Bibo Bergeron", Rating = 2 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTMxMjY0NzE2M15BMl5BanBnXkFtZTcwNTc3ODcyMw@@._V1_SY1000_CR0,0,677,1000_AL_.jpg";
            v.Plot = @"When a son of a gangster shark boss is accidentally killed while on the hunt, his would-be prey and his vegetarian brother both decide to use the incident to their own advantage.";
            result.Add(v);

            v = new Video() { VideoId = 25, Title = "Meet the Fockers", Year = 2004, Director = "Jay Roach", Rating = 1 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMWZjODQxMWMtZmIzYS00YjMwLWFiZTctYmFiZmJiNjljYWVmL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_SX675_AL_.jpg";
            v.Plot = @"All hell breaks loose when the Byrnes family meets the Focker family for the first time.";
            result.Add(v);

            v = new Video() { VideoId = 26, Title = "The Good Shepherd", Year = 2006, Director = "Robert De Niro", Rating = 2 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTU5MjExMzA1Nl5BMl5BanBnXkFtZTgwMzIxNzQxMTE@._V1_.jpg";
            v.Plot = @"The tumultuous early history of the Central Intelligence Agency is viewed through the prism of one man's life.";
            result.Add(v);

            v = new Video() { VideoId = 27, Title = "Righteous Kill", Year = 2008, Director = "Jon Avnet", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTYwMjg3MjY3OV5BMl5BanBnXkFtZTcwNTc4MDU3MQ@@._V1_SY1000_SX676_AL_.jpg";
            v.Plot = @"Two veteran New York City detectives work on a case of serial executions of criminals who escaped justice.";
            result.Add(v);

            v = new Video() { VideoId = 28, Title = "Stone", Year = 2010, Director = "John Curran", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTgxOTk4MDIyOF5BMl5BanBnXkFtZTcwMzI3Nzc3Mw@@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            v.Plot = @"A convicted arsonist looks to manipulate a parole officer into a plan to secure his parole by placing his beautiful wife in the lawman's path.";
            result.Add(v);

            v = new Video() { VideoId = 29, Title = "Cape Fear", Year = 1991, Director = "Martin Scorsese", Rating = 2 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "Not the best De Niro movie" });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNjdhNzZlYzYtYTBlNS00NTJiLWI2ZWUtMDI2YzI2MzM5NjY4XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SY1000_CR0,0,658,1000_AL_.jpg";
            v.Plot = @"A convicted rapist, released from prison after serving a fourteen-year sentence, stalks the family of the lawyer who originally defended him.";
            result.Add(v);

            v = new Video() { VideoId = 30, Title = "Marvin's Room", Year = 1996, Director = "Jerry Zaks", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BYjQ4MjI5YTItZmMxMS00NmU2LWIxMzYtOWE5YzdiYjcwNDAyXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg";
            v.Plot = @"A leukemia patient attempts to end a 20-year feud with her sister to get her bone marrow.";
            result.Add(v);

            v = new Video() { VideoId = 31, Title = "Guilty by Suspicion", Year = 1991, Director = "Irwin Winkler", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTU0ODQ5NTY2NV5BMl5BanBnXkFtZTcwMTIwNTMyMQ@@._V1_.jpg";
            v.Plot = @"David Merrill (Robert De Niro), a fictitious 1950s Hollywood director, returns from filming abroad in France to find that his loyalty has been called into question by the House Committee on Un-American Activities and he is unable to work until cleared.";
            result.Add(v);

            v = new Video() { VideoId = 32, Title = "Awakenings", Year = 1990, Director = "Penny Marshall", Rating = 5 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMjI5NjEzMDYyMl5BMl5BanBnXkFtZTgwNjgwNTg4NjE@._V1_SY1000_CR0,0,746,1000_AL_.jpg";
            v.Plot = @"The victims of an encephalitis epidemic many years ago have been catatonic ever since, but now a new drug offers the prospect of reviving them.";
            result.Add(v);

            v = new Video() { VideoId = 33, Title = "Once Upon a Time in America", Year = 1984, Director = "Sergio Leone", Rating = 5 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "The way the movie was cut is also the reason why a lot of Americans don't think this movie is very special. There are three versions, but only the European version is how the director imagined it to be. He didn't want his movie to be shown in chronological order (1910's - 1930's - 1960's), but wanted to mix these three periods of time. The studio cut the movie in chronological order, loosing a lot of its originality and therefor getting a lot of bad critics. If you want to see this film the way Sergio Leone saw it, you have to make sure you get the director's cut. " });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMGFkNWI4MTMtNGQ0OC00MWVmLTk3MTktOGYxN2Y2YWVkZWE2XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,639,1000_AL_.jpg";
            v.Plot = @"A former Prohibition-era Jewish gangster returns to the Lower East Side of Manhattan over thirty years later, where he once again must confront the ghosts and regrets of his old life.";
            result.Add(v);

            v = new Video() { VideoId = 34, Title = "True Confessions", Year = 1981, Director = "Ulu Grosbard", Rating = 2 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTA1NTAyMzM1ODVeQTJeQWpwZ15BbWU3MDMwNzI4NzQ@._V1_SY1000_CR0,0,650,1000_AL_.jpg";
            v.Plot = @"A worldly ambitious monsignor clashes with his older brother, a cynical Los Angeles homicide detective who is investigating the brutal murder of a young prostitute.";
            result.Add(v);

            v = new Video() { VideoId = 35, Title = "New York, New York", Year = 1977, Director = "Martin Scorsese", Rating = 3 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "I'm not going to watch this movie!" });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BYzZjM2RlZWMtZjVhNC00ODAyLTg0MDEtZDNmNjU4ODg2YjY3XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_.jpg";
            v.Plot = @"An egotistical saxophonist and a young singer meet on V-J Day and embark upon a strained and rocky romance, even as their careers begin a long, up-hill climb.";
            result.Add(v);

            v = new Video() { VideoId = 36, Title = "The Last Tycoon", Year = 1976, Director = "Elia Kazan", Rating = 2 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMGE4ZWE2ZDYtZDE4Ni00Njg0LWE2ZjctZmY0YTU1MjRjM2U5XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SY1000_CR0,0,663,1000_AL_.jpg";
            v.Plot = @"F. Scott Fitzgerald's novel is brought to life in this story of a movie producer slowly working himself to death.";
            result.Add(v);

            v = new Video() { VideoId = 37, Title = "Mean Streets", Year = 1973, Director = "Martin Scorsese", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMWNmNGY3ZGMtYWQ3OC00Zjg4LWFiN2EtZjM2MDI1YzRiNjg3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg";
            v.Plot = @"A small-time hood aspires to work his way up the ranks of a local mob.";
            result.Add(v);

            v = new Video() { VideoId = 48, Title = "City by the Sea", Year = 2002, Director = "Michael Caton-Jones", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTIwMjc1MzI3MF5BMl5BanBnXkFtZTYwMjUwMjY3._V1_.jpg";
            v.Plot = @"Vincent Lamarca, whose father was executed for a 1950s kidnapping of a child, grew up to become a police officer, only to see his own son become a murderer.";
            result.Add(v);

            v = new Video() { VideoId = 50, Title = "Silver Linings Playbook", Year = 2012, Director = "David O. Russell", Rating = 4 };
            v.Reviews = new Collection<Review>();
            v.Reviews.Add(new Review() { UserName = "UserA", ReviewText = "I did not know what to expect from this movie. It is a stunningly accurate trip into the mind of a BP sufferer. It shows the disease from the outside, too. It is amazing in its accuracy. The mood swings, the detachment from reality, the failure to learn from past errors are there. Here is a guy who has so messed up he is in the hospital. He is released into the custody of his parents. He improves himself physically yet cannot see what he has done, what he is now, and what the future portends with any sort of reality." });
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTM2MTI5NzA3MF5BMl5BanBnXkFtZTcwODExNTc0OA@@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            v.Plot = @"After a stint in a mental institution, former teacher Pat Solitano moves back in with his parents and tries to reconcile with his ex-wife. Things get more challenging when Pat meets Tiffany, a mysterious girl with problems of her own.";
            result.Add(v);

            v = new Video() { VideoId = 51, Title = "The Wizard of Lies", Year = 2017, Director = "Barry Levinson", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc2NDM5MDI2NV5BMl5BanBnXkFtZTgwOTc5NzQzMjI@._V1_.jpg";
            v.Plot = @"A chronicle of Bernie Madoff's Ponzi scheme, which defrauded his clients of billions of dollars.";
            result.Add(v);

            v = new Video() { VideoId = 52, Title = "The Comedian", Year = 2016, Director = "Taylor Hackford", Rating = 2 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTgyOTMzODE3Ml5BMl5BanBnXkFtZTgwMTk3NTM3MDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            v.Plot = @"A look at the life of an aging insult comic named Jack Burke.";
            result.Add(v);

            v = new Video() { VideoId = 53, Title = "Dirty Grandpa", Year = 2016, Director = "Dan Mazer", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMzk0NzkyNDk2M15BMl5BanBnXkFtZTgwNDczOTU3NzE@._V1_SY1000_CR0,0,657,1000_AL_.jpg";
            v.Plot = @"Right before his wedding, an uptight guy is tricked into driving his grandfather, a lecherous former Army Lieutenant-Colonel, to Florida for spring break.";
            result.Add(v);

            v = new Video() { VideoId = 54, Title = "Joy", Year = 2015, Director = "David O. Russell", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BNzRiOWZmMzUtZTJiOC00MjQ1LTkwMjgtNzhlYzBmODAzYTA0XkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_SY1000_SX675_AL_.jpg";
            v.Plot = @"Joy is the story of the title character, who rose to become founder and matriarch of a powerful family business dynasty.";
            result.Add(v);

            v = new Video() { VideoId = 55, Title = "Heist", Year = 2015, Director = "Scott Mann", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMjEzNTkyMDE3NV5BMl5BanBnXkFtZTgwMTM2MDY4NjE@._V1_.jpg";
            v.Plot = @"A father is without the means to pay for his daughter's medical treatment. As a last resort, he partners with a greedy co-worker to rob a casino. When things go awry they're forced to hijack a city bus.";
            result.Add(v);

            v = new Video() { VideoId = 56, Title = "The Intern", Year = 2015, Director = "Nancy Meyers", Rating = 4 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTUyNjE5NjI5OF5BMl5BanBnXkFtZTgwNzYzMzU3NjE@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            v.Plot = @"70-year-old widower Ben Whittaker has discovered that retirement isn't all it's cracked up to be. Seizing an opportunity to get back in the game, he becomes a senior intern at an online fashion site, founded and run by Jules Ostin.";
            result.Add(v);

            v = new Video() { VideoId = 57, Title = "The Bag Man", Year = 2014, Director = "David Grovic", Rating = 2 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMjE4NDc3NjUyNl5BMl5BanBnXkFtZTgwMDA4MDQwMTE@._V1_SY1000_SX677_AL_.jpg";
            v.Plot = @"A criminal bides his time at a seedy motel, waiting for his boss after killing several men and making away with a mystery bag.";
            result.Add(v);

            v = new Video() { VideoId = 58, Title = "Grudge Match", Year = 2013, Director = "Peter Segal", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTY3NTkxMTgzNV5BMl5BanBnXkFtZTgwNjg0MzE2MDE@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            v.Plot = @"A pair of aging boxing rivals are coaxed out of retirement to fight one final bout -- 30 years after their last match.";
            result.Add(v);

            v = new Video() { VideoId = 59, Title = "Las Vegas", Year = 2013, Director = "Jon Turteltaub", Rating = 3 };
            v.PosterUrl = @"https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ2ODg2MTIyNF5BMl5BanBnXkFtZTgwMzU2NjgwMDE@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            v.Plot = @"Four friends take a break from their day-to-day lives to throw a bachelor party in Las Vegas for their last remaining single pal.";
            result.Add(v);

            return result;
        }
    }
}
