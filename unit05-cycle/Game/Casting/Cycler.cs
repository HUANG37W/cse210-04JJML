using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A long limbless reptile.</para>
    /// <para>The responsibility of Cycler is to move itself.</para>
    /// </summary>
    public class Cycler : Actor
    {
        private List<Actor> segments = new List<Actor>();

        /// <summary>
        /// Constructs a new instance of a Cycler.
        /// </summary>
        public Cycler()
        {
            PrepareBody();
        }

        /// <summary>
        /// Gets the Cycler's body segments.
        /// </summary>
        /// <returns>The body segments in a List.</returns>
        public List<Actor> GetBody()
        {
            return new List<Actor>(segments.Skip(1).ToArray());
        }

        /// <summary>
        /// Gets the Cycler's head segment.
        /// </summary>
        /// <returns>The head segment as an instance of Actor.</returns>
        public Actor GetHead()
        {
            return segments[0];
        }

        /// <summary>
        /// Gets the Cycler's segments (including the head).
        /// </summary>
        /// <returns>A list of Cycler segments as instances of Actors.</returns>
        public List<Actor> GetSegments()
        {
            return segments;
        }
        

        /// <summary>
        /// Grows the Cycler's tail by the given number of segments.
        /// </summary>
        /// <param name="numberOfSegments">The number of segments to grow.</param>
        public void GrowTail(int numberOfSegments)
        {
                Actor tail = segments.Last<Actor>();
                Actor head = segments[0];
                Point velocity = head.GetVelocity();
                Point position = head.GetPosition();
                
               // head = new position and add head to list of segments

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetText("#");
                segment.SetColor(GetColor());
                segments.Insert(1, segment);
            // }
        }

        /// <inheritdoc/>
        public override void MoveNext()

        {
            Actor head = segments[0];
            Point position = head.GetPosition();

            
            GetHead().MoveNext();

            // for (int i = segments.Count - 1; i > 0; i++)
            // {
            //     Actor trailing = segments[i];
            //     Actor previous = segments[^1];
            //     Point velocity = previous.GetVelocity();
            //     trailing.SetVelocity(velocity);
            // }
        }

        /// <summary>
        /// Turns the head of the Cycler in the given direction.
        /// </summary>
        /// <param name="velocity">The given direction.</param>
        public void TurnHead(Point direction)
        {
            segments[0].SetVelocity(direction);
        }

        /// <summary>
        /// Prepares the Cycler body for moving.
        /// </summary>
        private void PrepareBody()
        {
            
            Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
            string text = "8";
            
            Actor segment = new Actor();
            segment.SetPosition(GetPosition());
            segment.SetVelocity(velocity);
            segment.SetText(text);
            segment.SetColor(GetColor());
            segments.Add(segment);
            
        }
    }
}