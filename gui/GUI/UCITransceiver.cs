﻿using System;
using System.IO;

namespace GUI
{
    public class UCITransceiver
    {
        Engine engine;
        public string EngineName { get; private set; }
        public string EngineAuthor { get; private set; }

        public UCITransceiver (string engineFilename)
        {
            try {
                engine = new Engine(engineFilename);
            } catch(FileNotFoundException) {
                throw new ArgumentException ("Bad engine filename provided.", "engineFilename");
            }
            engine.Start ();
        }

        public void Init()
        {
            engine.Write("uci");
            string response;
            do {
                response = engine.Read();
                if(response.StartsWith("id name ")) {
                    EngineName = response.Substring(8);
                } else if(response.StartsWith("id author ")) {
                    EngineAuthor = response.Substring(10);
                } else if(response == "uciok") {
                    return;
                }
            } while(response != null);

            engine.Write ("isready");
            do {
                response = engine.Read ();
                if (response == "readyok") {
                    return;
                }
            } while(response != null);
        }

        /**
         * @fn SendPosition
         * @brief Sends the current board position to the engine.
         * 
         * @param position either a valid FEN string or "startpos" to use the default starting position.
         * @param moves a string of space-delimited moves made since @c position. Optional.
         */
        public void SendPosition(string position, string moves = null)
        {
            string output = "position " + position;
            if (moves != null) {
                output += " moves " + moves;
            }
            engine.Write (output);
        }

        public void Go(string time = "infinite") {
            engine.Write("go " + time);
        }

        public string StopAndGetBestMove()
        {
            engine.Write("stop");
            string response;
            do {
                response = engine.Read ();
                if (response.StartsWith ("bestmove")) {
                    return response.Substring (9, 4);
                }
            } while(response != null);
            throw new TimeoutException ("Engine has stopped responding.");
        }

        public void WaitUntilReady()
        {
            engine.Write("isready");
            string response;
            do {
                response = engine.Read ();
                if (response == "readyok") {
                    return;
                }
            } while(response != null);
        }

        public void Quit()
        {
            engine.Write("quit");
        }
    }
}
