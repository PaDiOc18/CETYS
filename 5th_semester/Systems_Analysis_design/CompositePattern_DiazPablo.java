--------------------
[Program.java]
--------------------
public class Program {

	public static void main(String args[]) {
	
	// Make new empty "Study" playlist 
	Playlist studyPlaylist = new Playlist("Study");		

	// Make "Synth Pop" playlist and add 2 songs to it.
	Playlist synthPopPlaylist = new Playlist("Synth Pop");
	Song synthPopSong1 = new Song("Girl Like You", "Toro Y Moi" );
	Song synthPopSong2 = new Song("Outside", "TOPS");
	synthPopPlaylist.add(synthPopSong1);
	synthPopPlaylist.add(synthPopSong2);

	// Make "Experimental" playlist and add 3 songs to it, 
	// then set playback speed of the playlist to 0.5x
	Playlist experimentalPlaylist = new Playlist("Experimental");		
	Song experimentalSong1 = new Song("About you", "XXYYXX");
	Song experimentalSong2 = new Song("Motivation", "Clams Casino");	
	Song experimentalSong3 = new Song("Computer Vision", "Oneohtrix Point Never");
	experimentalPlaylist.add(experimentalSong1);
	experimentalPlaylist.add(experimentalSong2);
	experimentalPlaylist.add(experimentalSong3);
	float slowSpeed = 0.5f;
	experimentalPlaylist.setPlaybackSpeed(slowSpeed);
	
	// Add the "Synth Pop" playlist to the "Experimental" playlist
	experimentalPlaylist.add(synthPopPlaylist);

	// Add the "Experimental" playlist to the "Study" playlist
	studyPlaylist.add(experimentalPlaylist);

	// Create a new song and set its playback speed to 1.25x, play this song, 
	// get the name of glitchSong â†’ "Textuell", then get the artist of this song â†’ "Oval"
	Song glitchSong = new Song("Textuell", "Oval");
	float fasterSpeed = 1.25f;
	glitchSong.setPlaybackSpeed(fasterSpeed);
	glitchSong.play(); 
	String name = glitchSong.getName(); 
	String artist = glitchSong.getArtist(); 
	System.out.println ("The song name is " + name );
	System.out.println ("The song artist is " + artist );

	// Add glitchSong to the "Study" playlist
	studyPlaylist.add(glitchSong);

	// Play "Study" playlist.
	studyPlaylist.play(); 

	// Get the playlist name of studyPlaylist â†’ "Study"
	System.out.println ("The Playlist's name is " + studyPlaylist.getName() );
	}
}

--------------------
[IComponent.java]
--------------------
public interface IComponent {

	// Your code goes here!
	public play(){

	}
	public setPlaybackSpeed(float speed){

	}
	public getName(){

	}


}

--------------------
[Playlist.java]
--------------------
public class Playlist implements IComponent {

	public String playlistName;
	public ArrayList<IComponent> playlist = new ArrayList();

	public Playlist(String playlistName) {
		this.playlistName = playlistName;
	}

  // Your code goes here!
	public play(){
		for (IComponent component: playlist) {
			component.play();
		}
	}

	public setPlaybackSpeed(float speed){
		for (IComponent component: playlist) {
			component.setPlaybackSpeed(this.speed);
		}
	}

	public getName(){
		return this.playlistName;
	}

	public add(IComponent component){
		this.playlist.add(component);
	}

	public remove(IComponent component){
		this.playlist.remove(component);
	}

}

--------------------
[Song.java]
--------------------
public class Song implements IComponent {
	public String songName;
	public String artist;
	public float speed = 1; // Default playback speed

	public Song(String songName, String artist ) {
		this.songName = songName;
		this.artist = artist; 
	}
	// Your code goes here!
	public play(){
		//reproduce song
	}

	public setPlaybackSpeed(float speed){
		this.speed = speed;
	}

	public getName(){
		return this.songName;
	}

	public getArtist(){
		return this.artist;
	}
	
}