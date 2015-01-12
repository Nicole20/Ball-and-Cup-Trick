using UnityEngine;
using System.Collections;

public class CupMove : MonoBehaviour
{
	private int move;
	private int count;
	public Transform[] cups;

	// Use this for initialization
	void Start ()
	{
		count = Random.Range(4, 9); //4 to 8
		move = Random.Range (1, 7);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//print (move);
		//print (count);
		if (count != 0)
		{
			if ((!cups[0].animation.isPlaying) && (!cups[1].animation.isPlaying) && (!cups[2].animation.isPlaying))
			{
				move = Random.Range(1, 7);
				count--;

				if (move == 1 || move == 6)
				{
					if (cups[0].position.x == 0)
					{
						cups[0].animation.Play ("CupMove2-1");
						if(cups[1].position.x == -4)
						{
							cups[1].animation.Play ("CupMove1-2");
						}
						else if(cups[2].position.x == -4)
						{
							cups[2].animation.Play ("CupMove1-2");
						}
					}
					else if (cups[0].position.x == -4)
					{
						cups[0].animation.Play ("CupMove1-2");
						if(cups[1].position.x == 0)
						{
							cups[1].animation.Play ("CupMove2-1");
						}
						else if(cups[2].position.x == 0)
						{
							cups[2].animation.Play ("CupMove2-1");
						}
					}
				}
				else if (move == 3 || move == 4)
				{
					print ("test");
					if (cups[0].position.x == 0)
					{
						cups[0].animation.Play ("CupMove2-3");
						if(cups[1].position.x == 4)
						{
							cups[1].animation.Play ("CupMove3-2");
							print ("test1");
						}
						else if(cups[2].position.x == 4)
						{
							cups[2].animation.Play ("CupMove3-2");
							print ("test2");
						}
					}
					else if (cups[0].position.x == 4)
					{
						cups[0].animation.Play ("CupMove3-2");
						if(cups[1].position.x == 0)
						{
							cups[1].animation.Play ("CupMove2-3");
							print ("test3");
						}
						else if(cups[2].position.x == 0)
						{
							cups[2].animation.Play ("CupMove2-3");
							print ("test4");
						}
					}
				}
				else if (move == 2 || move == 5)
				{
					if (cups[0].position.x == -4)
					{
						cups[0].animation.Play ("CupMove1-3");
						if(cups[1].position.x == 4)
						{
							cups[1].animation.Play ("CupMove3-1");
						}
						else if(cups[2].position.x == 4)
						{
							cups[2].animation.Play ("CupMove3-1");
						}
					}
					else if (cups[0].position.x == 4)
					{
						cups[0].animation.Play ("CupMove3-1");
						if(cups[1].position.x == -4)
						{
							cups[1].animation.Play ("CupMove1-3");
						}
						else if(cups[2].position.x == -4)
						{
							cups[2].animation.Play ("CupMove1-3");
						}
					}
				}
			}
		}
	}
}
