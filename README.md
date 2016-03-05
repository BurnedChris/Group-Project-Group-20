# Group 20 - Group Project
### Repository movment.
This repo has been moved from https://github.com/Burnsyy/Group20 to https://github.com/Burnsy/Group20. Please update the links and git links.
## Contributors
Chris Burns (13465853@students.lincoln.ac.uk)<br>Peter Goudie (12447330@students.lincoln.ac.uk)<br>Nathan Dawson  (14474842@students.lincoln.ac.uk)<br>Alexander Sainsbury (12453137@students.lincoln.ac.uk)<br>Amy Hill (13455917@students.lincoln.ac.uk)<br>Ashley Statham (14470643@students.lincoln.ac.uk)<br>James P Wearing (12453960@students.lincoln.ac.uk)
## supervisor
Kathrin Gerling(kgerling@lincoln.ac.uk)

## Video
[![Group 20's Short Video - CMP2089M Group Project Assessment Item 1](http://img.youtube.com/vi/G4t85NzI2jg/0.jpg)](http://www.youtube.com/watch?v=G4t85NzI2jg "Group 20's Short Video - CMP2089M Group Project Assessment Item 1")

The video made explaining and justifying our chosen project can be found at the link below, as an unlisted YouTube video. It has also been uploaded separately to the assessment area.

## Introduction
### Project Proposal - an introduction that explains the rationale and logic for the chosen case study of the project
In this task we set out with the aim to develop an artificial intelligence system in a game that is capable of passing the Turing Test, designed by Alan Turing. In his 1950 paper which Turing wrote on Artificial Intelligence (AI) he describes a test in which an external party, known as an interrogator, must determine which of two candidates is a man and which is a woman. From this 'Imitation Game' Turing proceeded to asked what if instead the candidate was not a woman but a machine. This revision of the test would still involve the interrogator playing a game of question and answer with the two subjects located in another room, and receiving written based answers to his questions. The interrogator's task is then to determine which of the subjects was human and which was a machine. If the interrogator was unable to tell which is the machine then it would be considered intelligent and therefore pass the test (Livingstone, 2006).

In our version of the test we are going to create a simple game based on the "Light Cycle" mini-game from the classic arcade game "Tron" (Bally Midway, 1982). This takes the concept of the game "Snake" (Taneli Armanto, 1997) and adds a competitive element. As opposed to just having the interrogator observing several recordings of the game, as was done in Livingstone's tests carried out in 2004 (Livingstone, 2006), more on his work follows in the literature review. We will have our interrogator physically play the game against an unknown opponent. Once the interrogator has played the game, they will be asked to decide if they believe their opponent was another human or an Artificial Intelligence. If they believe their opponent was a human being, then we can assume that the AI has shown rudimentary intelligence and has therefore passed the basics of the turing test.

The game will be created from the ground up in the Unity game engine, (Unity Technologies, 2016) which is a platform that has proven useful when developing 3d and 2d games. The development environment within the unity engine allows games to be developed using a what-you-see-is-what-you-get editor, as well as via a programming API interfaceable via C#. We will be using Unity's 2D tools to create the game as it is played from a top-down view of a grid which has the two players moving up, down, left or right, leaving a trail behind them which acts as a wall. This trail left behind is used in an attempt to guide the opponent into crashing, either into the walls of the grid or into the trails emitted from either player.

Due to the nature of the game, it is likely that the AI will lose as many games as it is able to win. This can occur for several different reasons such as the AI selecting the wrong course of action and crashing into a wall or just being outplayed by the human opponent. If there was a higher certainty of victory, it would be a good idea to include some algorithms that cause the AI to lose, for example having the AI crash into a wall seemingly accidentally. This would compensate for human error which would aid in masking the Artificial Intelligence. Since the human opponent has as much chance of winning the game as the AI, this idea can be left as an afterthought and brought back at a later date if it is deemed necessary.

We have researched into different strategies of how we can implement the AI in game. These strategies would see our developed AI being able to convince the opposing player that it is behaving in a human like manner, whether it were to win or not. The techniques which we are going to implement vary in complexity, from simply randomly selecting a direction to move after a random amount of time, to algorithms that will have the AI calculating the best paths to isolate the opponent and force them into a wall or obstacle.

Implementing a variety of these strategies would aid in masking the AI's true identity, as, in theory, it would behave in a more human like manner. Using one strategy alone would cause the AI player to repeat almost the same interactions every game, potentially revealing to the human opponent that they are likely playing against an AI rather than another human being. Alternatively the AI could just move so randomly and sporadically it would reveal that it is a programmed AI, as it would show it moving with no actual aim or purpose, something which is unlikely to occur in a competitive, human versus human game. Having a multitude of different strategies available to it will allow the AI to move randomly enough to not appear as if it is just following a set of rules but will also actively attempt to select the best strategy in which to beat the opponent, or at the very least convince them it is another human being.

In the proposed scenario, the Light Cycle game also offers various advantages helping simplify the artificial intelligence, such as being limited to a grid and 4-way movement, unable to move on a diagonal axis. Due to the nature of the artificial intelligence in question, a simple version of pathfinding is required to ensure it understands what a safe pathway is and what it cannot move through, possible via heuristic checks. As well as the mentioned, it also features few entities which can move in the world space, as well as objects which have to be accounted for when considering the objective of the game (and AI), which reduces the error margin when attempting to path through the world space.

## Literature Review / Aims & Objectives
### A review of recent and relevant academic literature on game-based artificial intelligence
Once we decided on making a game-based artificial intelligence, we began research into the field, looking at a range of different materials to discover progress made by others and whether there is a gap in the market for new developments.

Artificial Intelligence in games can be applied on two levels: individual character artificial intelligence, which has the goal of producing intelligent behaviour that is capable of convincing humans that it may not be a computer or global artificial intelligence that can influence and steer the direction in which the game is taking. Each of these levels are applied depending on the genre of the game so that the AI is suitable, for example, it would make sense to apply individual character artificial intelligence to characters in a role-playing game as each character would be unique and have different behaviours. Whereas strategy games may apply a global (game level) AI which controls multiple units at once (Raju et al, 2012).

It is inevitable that there will be problems that developers come across when creating an AI in a game. Some challenges include: learning and memory, unanticipated situations, user-specific adaptation etc. Many games, notably in the strategic genre have complex and huge decision spaces. The developers tend to code "handcraft-strategies" for the AI, however the human player may easily be able to find loopholes and exploit them. It is not feasible for the Artificial Intelligence to be able to predict all strategies made by the player and this therefore leads to many unforeseen circumstances. The AI may struggle to behave appropriately as a consequence of these situations (Raju et al, 2012).

In some cases, expert players in certain games are able to predict the movements of AI and are therefore are more likely to win. Nowadays, there is Artificial Intelligence in games that are being developed to be able to behave more like humans and try to avoid easily detectable patterns in movement. These advancements in AI create more challenges and make it more fun for the user to play. Many of these developers aim for their machine to pass the Turing test and through machine learning techniques this could be possible.

Turing's test has inspired many other styles of test which can be used to determine how intelligent an AI is. One such method is the Loebner test. Unlike the Turing test where it is unclear that the interrogator knows there is a possibility of one subject being a computer, the Loebner test makes an explicit point of making all human judges aware that they are interrogating both a mix of humans and computers. This test, like the Turing test, focus on the ability of machines to demonstrate intelligence, not to prove that they are intelligent. Turing was aware that there may be difficulties proving that a machine is intelligent when comparing their behaviour to the formal definitions of intelligence.

Other research has been made into developing a convincing game AI, which could be used to pass the turing test. A 2006 paper written by Daniel Livingstone discusses how a traditional game AI works along the same basic principles as an AI which is attempting to beat the turing test. He states that for game developers the facade is what counts, in games believability is more important than truth. The goal of AI in games is to create a believable intelligence by any means necessary (Livingstone, 2006).

A paper written by Stevan Harnad in 2001 states that Turing's 1950 paper described a very general and methodological criterion for modelling, and that this criterion gives rise to a hierarchy of possible Turing Tests. His paper ranks the required levels of intelligence in tiers. These tiers range from t1, known as toy, all the way to t5 which is indistinguishable to human knowledge and behaviours. For games, the most likely level required for an AI would be t1. For this level of intelligence the machine is required to replicate some fragments of human functional capacity (Harnad, 2003).

Following on from this, and relating to the strategies that were discussed in the introduction, it is likely that the developed AI will work based on a hierarchy of possible decisions for any given situation. The decisions will be rather basic, as they will be based solely on movement and player tracking, with the AI working through a combination of 'if' statements and other minor algorithms. These algorithms and statements would branch out from one another leading the AI to implement the most appropriate strategy for the situation.

A good method for designing this basic AI would be to use finite state machines (FSMs). These FSMs describe when a current action should be replaced by another due to changing game conditions. Although these are used primarily in the design phase of an AI, they are instrumental to programmers when it comes to scripting the AIs actions (Nareyek, 2004). Decision trees are very similar to FSMs, and in some respects are considered simpler. These are branching structures which are generally used to make high level strategic decisions. The decision trees consist of nodes, branches and leaves. The nodes in a decision tree contain all the test conditions, these mainly comprise of if then statements. The branches which link nodes together allow for visualisation of how one set of test conditions will lead to the next. At the end of a string of nodes is the leaf, this is the final decision which the AI will then proceed to carry out.

In our research we found that when we come to develop the artificial intelligence part of the artefact,  it would be composed of three key parts in the code if we followed a careful standard. This would be made up of "a general mechanism for managing AI behaviours", "a world-interfacing system for getting information into the AI" and "a standard behaviour structure to liaise between the two" (Millington and Funge, 2009.) The importance of planning ahead when we come to the implementation of the game's AI as mentioned in the GANTT chart overleaf is clear, so that a strong support framework is in place before specific techniques for movements and other actions of the AI-controlled character are coded. Following this plan should allow us to have a more flexible structure that will lead to less time spent having to deal with older code if bugs arise during development.

## GANTT Chart
![gantt chart](/gantt.png)

## Risk table

                | Less Severe                                                                                             | Problematic                                                                             | Severe                                                                                                                 | Highly Severe
:-------------: | :-----------------------------------------------------------------------------------------------------: | :-------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------:
Highly Unlikely | Team members missing out on meetings.(Highly Unlikely, Less severe)                                     | Miscommunication of goals between team members.(Highly Unlikely, Problematic)           | Availability of experts for help when designing the program.(Highly Unlikely, Severe)                                  | Lack of software availability across equipment, and no access to sufficient equipment.(Highly Unlikely, Highly Severe)
Unlikely        | Availability of the software to create the game and AI.(Unlikely, Less severe)                          | Lack of available room space for meetings and development.(Unlikely, Problematic)       | Team members becoming ill during the project.(Unlikely, Less severe)                                                   | Complete loss of all created work.(Unlikely, Highly Severe)
Possible        | The amount of time necessary to complete the project vs the amount of time left.(Possible, Less severe) | Disagreement on what the overall project should be based around.(Possible, Problematic) | Missed project deadlines. (Likely, Severe)                                                                             | Technical issues such as broken laptops or software(Possible, Highly Severe)
Likely          | Difficulty organising external meetings due to people's schedules.(Likely, Less severe)                 | Difficulty acquiring open source assets for the development.(Likely, Problematic)       | Acquiring a location which can facilitate the program and allow access to the interrogator and player.(Likely, Severe) | The AI being too powerful that it becomes blatant it’s an AI.(Likely, Highly Severe)
Highly Likely   | Lack of game development experience.  (Highly Likely, Less severe)                                      | Bugs within the code during development (Highly Likely, Severe)                         | Productivity issues.(Highly Likely, Highly Severe)                                                                     | Inability to produce an AI that sufficiently completes the ruleset of the game (Highly Likely, Highly Severe)

## Risk Mitigation
### Low risks issues
Team members missing meetings - This is not a disastrous issue if members of the team were to miss some meetings. This is because we have a large amount of communication with each other via internet based group chats, and multi-user contribution documents such as Google Docs. Goal miscommunication - This would be an early stage issue which would be sorted out swiftly through extended dialogue and if necessary a vote on what actions to take. Software availability - To manage this risk it would be a good idea to be sure that all desired software is available to use on the university network. Any standalone software could cause issues for members of the group who do not also own it. Lack of time to complete the project - As the entire project span is only twelve weeks a through plan of action is required. The use of a gantt chart will aid in meeting deadlines and milestones and actively help in maintaining good time management.

### Medium risks
Availability of meeting and development space - To ensure that there will always be somewhere we can work upon the project, rooms will be booked several days in advance at an agreed upon time. Team member illness and absence during development - To ensure that no part of the project is left unmanned and development grinds to a halt, we will ensure that at least two people are working on the same section of the development. This will allow either one to take control should the other member be ill or absent. Open source asset acquisition - Acquiring assets for the project could become problematic due to licensing issues. To avoid this it may be an idea to have some of our own developed assets in game instead. This would however require more time being allocated to the design of the game potentially removing focus from other areas of the development, such as the construction of the AI. Lack of game development experience - The majority of the members within the team have little to no experience about developing a game. However, to combat this the design of the game has been kept simple, the environment in which it is to be built is well known and supported, and time has been allocated for people to learn some very basic game coding via the unity tutorials website. Availability of experts or supervisors - Although not as likely as some of the other medium risks, being able to contact experts and supervisors will go along way toward guiding us to a successful project. To ensure the greatest amount of availability, liaising with our supervisor at regular intervals will be necessary.

### High risks
Complete loss of all work - This, although being an unlikely situation, would have a catastrophic effect on the overall project's development. To ensure that this situation does not arise we will back up our work to several secure locations and make sure that each team member has a copy of the relevant work. Technical issues - These include corrupted software or broken equipment. Apart from a potential loss of work that could result in a halt to the project, technical issues could mean a complete rethinking of how we implement the AI or create the game. To ensure that this situation does not occur research into the best software to use will be carried out, alternatives will be planned for just in case and, to prevent loss of work due to broken equipment, backups of all work will be kept online through services such as google docs, GitHub and dropbox. Coding bugs - Bugs are very likely to occur during the development phase of the AI and the game itself. Although likely to occur, they will not be a large hindrance to the project as a team of developers working together effectively should be able to find solutions to most problems. Successful implementation of version control should allow us to come up with solutions to bugs without disrupting other developers or potentially causing larger problems in the overall project. Overly complex AI - Whilst not appearing to be a problem at first, if the AI is too competent that it becomes obvious to an external party that it is in fact not a human opponent, the AI has failed the turing test and therefore the project has failed. This can be solved by adding in algorithms to replicate human error such as having the AI player occasionally crash into walls seemingly accidentally. This could fool a human opponent into believing their opponent has a realistic reaction speed rather than the improved reactions of an AI. Insufficient AI - One of the greatest risks to the project may be our inability to construct an AI that will adequately pass the Turing Test. To this end we will design and develop the AI whilst working along the guidelines set out by Turing.

## Mark Allocation

Group Members       | Mark Achieved
:-----------------: | :-----------:
James Wearing       | A
Christopher Burns   | A
Amy Hill            | A
Peter Gouldie       | A
Nathan Dawson       | A
Ashely Statham      | A
Alexander Sainsbury | A

We have allocated everyone in the group the entire amount of marks as we felt that even throughout occasional absences that every group member produced a quantitive and qualitive amount of work. The tasks which members were allocated were completed in a sufficient time even with the aforementioned problem. Group members also self managed to a certain point and collaborated well to achieve the desired result.

## References
1. Billings, D., Davidson, A., Schaeffer, J. and Szafron, D. (2002) The challenge of poker. Artificial Intelligence, 134(1–2) 201-240.
2. Raju, Sikka, N., Kumar, S. and Gupta, R. (2012) Artificial Intelligence in Games. International Journal of Soft Computing and Engineering, 2(5) 269-273.
3. Millington, I. and Funge, J. (2009) Artificial Intelligence for Games. 2nd edition. Boca Raton: CBC Press.
4. Speed, E. (2012) Artificial intelligence for games. US20120157176 A1. United States. Available from [https://docs.google.com/viewer?url=patentimages.storage.googleapis.com/pdfs/US20120157176.pdf](https://docs.google.com/viewer?url=patentimages.storage.googleapis.com/pdfs/US20120157176.pdf) [Accessed 10 February 2016].
5. Aiolli, F. and Palazzi, C.E. (2008) Enhancing Artificial Intelligence in Games by Learning the Opponent's Playing Style. New Frontiers for Entertainment Computing, 279 1-10.
6. Livingstone, D. (2006) Turing's Test and Believable AI in Games. ACM Computers in entertainment, 4(1) 1-13.
7. Harnad, S., 2003. Minds, machines and Turing. In The Turing Test (pp. 253-273). Springer Netherlands.
8. Nareyek, A., 2004. AI in computer games. Queue, 1(10), p.58-65 Bally Midway (1982) Tron. [game] Illinois, USA: Midway Games. [Accessed 3rd February 2016].
9. Taneli Armanto (1997) Snake. [game] Espoo, Finland: Nokia. [Accessed 3rd February 2016]
10. Unity Technologies (2016) Unity 5 Game Engine. [software] version Windows 7/8/10 Mac OS X 10.8+. San Francisco, USA: Unity Technologies.
11. University of Waterloo Computer Science Club (2010) Google AI Challenge. [online] Waterloo: University of Waterloo Computer Science Club. Available from [http://csclub.uwaterloo.ca/contest/xiao_strategy.php](http://csclub.uwaterloo.ca/contest/xiao_strategy.php) [Accessed 12 February 2016].
12. Poo Castro, P.O. (2013) A simple Tron bot. [online] Waterloo: University of Waterloo Computer Science Club. Available from [http://www.sifflez.org/misc/tronbot/index.html](http://www.sifflez.org/misc/tronbot/index.html) [Accessed 12 February 2016]

## Appendix

### Key
| Letter | Definition |
|--------|------------|
| X      | Attended   |
|        | Missed     |
| I      | Illness    |
| N      | Attendance not required |

P & D currently are filler text, will be updated soon.

### Table

| Meeting | Alex | Amy | Ashley | Chris | James | Nathan | Peter | Progress Made | Decisions Taken |
|---------|------|-----|--------|-------|-------|--------|-------|---------------|-----------------|
| 1 (SV) - 28/01/16   | X | X | X | X |   | X | X | P | D |
| 2 - 03/02/16        | X | X | X | X | X | X | X | P | D |
| 3 (SV) - 04/02/16   |   | X | X | X |   | X | X | P | D |
| 4 - 05/02/16        | X | X | X | X | X | X | X | P | D |
| 5 - 10/02/16        | X |   | X | X | X |   | X | P | D |
| 6 (SV) - 11/02/16   | X | I | X | X | I | X | X | P | D |
| 7 - 12/02/16        | X | X | X | X | X | X | X | P | D |
| 8 - 15/02/16        | X | X | X | X |   | X | X | P | D |
| 9 (SV) - 16/02/16   | N | N | X | N | N | N | X | P | D |
| 10 - 17/02/16       | X | X | X | X | X | X | X | P | D |
| 11 (SV) - 18/02/16  | N | X | X | X | N | N | X | P | D |
| 12 (SV) - 25/02/16  | X | X | X | X |   | X | X | P | D |
| 13 - 02/03/16       | X | X | X | X | I | X | X | P | D |
