#!/usr/bin/env python3
#
# Copyright (c) 2019-2020 LG Electronics, Inc.
#
# This software contains code licensed as described in LICENSE.
#

from environs import Env
import lgsvl
import time
import random
import sys
import os
from pathlib import Path
env = Env()

# Taking arguments for weather parameters and scene
rain = 0
fog = 0
wetness = 0
cloudiness = 0
damage = 0
scene = "781b04c8-43b4-431e-af55-1ae2b2efc877" #JTA_R2 Map
home = str(Path.home())
file = open(home+'/pid','w')
t = os.getpid()
pid = str(t)
file.write(pid)
file.close()
print("pid : ",pid)

if sys.argv[1]: 
   rain = float(sys.argv[1])
   fog = float(sys.argv[2])
   wetness = float(sys.argv[3])
   cloudiness = float(sys.argv[4])
   damage = float(sys.argv[5])
 


sim = lgsvl.Simulator(env.str("LGSVL__SIMULATOR_HOST", "127.0.0.1"), env.int("LGSVL__SIMULATOR_PORT", 8181))
if sim.current_scene == scene:
    sim.reset()
else:
    sim.load(scene)

'''
sim.set_time_of_day(09.00, False)
print(sim.time_of_day) '''

sim.weather = lgsvl.WeatherState(rain, fog, wetness, cloudiness, damage)

spawns = sim.get_spawn()
forward = lgsvl.utils.transform_to_forward(spawns[0])
right = lgsvl.utils.transform_to_right(spawns[0])


state = lgsvl.AgentState()
state.transform = spawns[0]
state.transform.position = spawns[0].position + 2 * forward + 1 * right    # -2
state.transform.rotation = spawns[0].rotation + 2.5

ego = sim.add_agent(env.str("LGSVL__VEHICLE_0","5ab8175f-e1f1-427c-a86e-e882fa842978"), lgsvl.AgentType.EGO, state)


# The EGO is now looking for a bridge at the specified IP and port
#ego.connect_bridge(env.str("LGSVL__AUTOPILOT_0_HOST", "127.0.0.1"), env.int("LGSVL__AUTOPILOT_0_PORT", 9090)) vb
ego.connect_bridge(os.environ.get("BRIDGE_HOST", "127.0.0.1"), 9090)


forward = lgsvl.utils.transform_to_forward(spawns[0])
right = lgsvl.utils.transform_to_right(spawns[0])
statej = lgsvl.AgentState()
statej.transform.position = spawns[0].position + 60 *forward 
statej.transform.rotation = spawns[0].rotation 
statej.velocity = 10 * forward
jeep = sim.add_agent("Jeep", lgsvl.AgentType.NPC, statej)
jeep.follow_closest_lane(True, 10.5)  # 11.1 m/s is ~40 km/h


# An EGO will not connect to a bridge unless commanded to
print("Bridge connected:", ego.bridge_connected)

#npc.on_collision(on_collision)

# for i, name in enumerate(["SUV", "SUV"]):
#     state1 = lgsvl.AgentState()
#     state1.transform.position = spawns[0].position + (15 * forward) - (3.0 * i * right) # + 10.0 * forward
#     state1.transform.rotation = spawns[0].rotation
#     npc = sim.add_agent(name, lgsvl.AgentType.NPC, state1)
#     npc.follow_closest_lane(True, 5)

#input("press Enter to run ")
sim.run()

