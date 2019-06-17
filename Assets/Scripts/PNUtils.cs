﻿/*
* Full-length Legal Copy:
* 1. Subject to the terms and conditions of this License Agreement (the “License”), Beijing Noitom Technologies Ltd. (“Noitom”) hereby grants to you a perpetual, worldwide, non-exclusive, no-charge, royalty-free, sublicenseable copyright license to use, reproduce, redistribute (subject to restrictions below), modify, and improve the software contained in this Perception Neuron Software Development Kit (“Perception Neuron SDK”), including, but not limited to, the samples, headers, libraries and source. This license is subject to the following terms and conditions:
* 1.1. This license includes the non-exclusive license and right to use (i) the Perception Neuron SDK to make applications, content, games and demos (collectively and generally referred to as “Developer Content”) that run using Perception Neuron hardware and which may incorporate the Perception Neuron SDK in whole or in part in binary or object code; and (ii) to use the Perception Neuron SDK to create derivative works of the Perception Neuron SDK itself (“Perception Neuron SDK Derivatives”), whether in source, binary, or object form, in whole or in part, including third party software unless otherwise noted.
* 1.2. Perception Neuron SDK Derivatives are further defined as source, binary or object code derived exclusively from the Perception Neuron SDK by you; provided, however, that Perception Neuron SDK Derivatives do not include the Developer Content (engines, utilities, applications, content, games or demos) which may be developed using the Perception Neuron SDK. By way of example a game or demo that is developed using the Perception Neuron SDK would not be a Perception Neuron SDK Derivative , nor would a utility or tool set in a pre-existing game engine that is adapted to work with the Perception Neuron SDK be a Perception Neuron SDK Derivative. By way of example, but not limitation, a Perception Neuron SDK Derivative is or would be: either (i) an adaptation of a utility or piece of code from the Perception Neuron SDK to improve efficiency; or(ii) an addition of code or improvement to the Perception Neuron SDK that adds functionality.
* 1.3 For the sake of clarification when you use the Perception Neuron SDK (including Perception Neuron SDK Derivatives) in or with Developer Content, you retain all rights to your Developer Content, and you have no obligations to share or license Developer Content (including your source and object code) to Noitom or any third parties; provided, however, Noitom retains all rights to the Perception Neuron SDK and the Perception Neuron SDK Derivatives that may be incorporated into your Developer Content.
* 2. You, the recipient and user of the Perception Neuron SDK, hereby agree and accept that that Noitom shall own all right, title and interest to the intellectual property rights, including, but limited to copyright, trademark and patent rights, to any Perception Neuron SDK Derivatives that you may create, and you hereby assign any and all such rights to such Perception Neuron SDK Derivatives to Noitom, subject to the following.
* 2.1 We hereby grant to you the a fully paid up, no-charge, royalty-free, world-wide, in perpetuity, non-exclusive right and license back to use these Perception Neuron SDK Derivatives solely in conjunction with the Perception Neuron SDK(or any components of the Perception Neuron SDK) and/or Developer Content on Noitom Products as set forth herein.
* 2.2 Furthermore, for the sake of clarification, Noitom and its assignees and licensees shall be free to use such Perception Neuron SDK Derivatives without any approval from you and without compensation or attribution to you.
* 2.3 You also agree upon Noitom’s request to provide the source and binary code of any Perception Neuron SDK Derivatives to Noitom. FAILURE TO COMPLY WITH THIS REQUEST IS THE BASIS FOR AUTOMATIC TERMINATION OF THIS LICENSE BY Noitom.
* 3. Subject to the terms and conditions of this License, your license to redistribute and sublicense the Perception Neuron SDK and Perception Neuron SDK Derivatives is also expressly made subject to the following conditions:
* 3.1. You may sublicense and redistribute the source, binary, or object code of the Perception Neuron SDK in whole or in part by itself for no charge or as part of a for charge piece of Developer Content; provided, however, you may only license, sublicense or redistribute the source, binary or object code of Perception Neuron SDK in whole, and you may not license, sublicense or redistribute any portion or element of Perception Neuron SDK separately or in part (in either source, binary or object form). If you license, sublicense or redistribute Perception Neuron SDK Derivatives in and of themselves (not as a part of a piece of Developer Content) then you may only do that solely with and in conjunction with the Perception Neuron SDK. The Perception Neuron SDK, any Perception Neuron SDK Derivatives, and any Developer Content may only be used with Noitom approved Products and may not be used, licensed, or sublicensed to interface with software or hardware or other commercial motion capture products that are not authorized and approved by Noitom;
* 3.2. You must include with all such redistributed or sublicensed Perception Neuron SDK or Perception Neuron SDK Derivatives code the following copyright notice: “Copyright © 2014 Beijing Noitom Technologies Ltd. All rights reserved,” and include the list of conditions contained in this Section3, including the full text of the disclaimer in Section 3.6 below;
* 3.3. Neither the name of Beijing Noitom Technologies Ltd. nor the names of Beijing Noitom Technologies Ltd.’s contributors, licensors, employees, or contractors, may be used to endorse or promote products derived from this Perception Neuron SDK without specific prior written permission of Beijing Noitom Technologies Ltd.;
* 3.4. You must give any other recipients of the Perception Neuron SDK or any elements thereof, including Perception Neuron SDK Derivatives, a copy of this License as such recipients, licensees or sublicensees may only use the Perception Neuron SDK or any Perception Neuron SDK Derivatives or any elements thereof subject to the terms of this License and such recipients, licensees or sublicensees agreement and acceptance of this License with Perception Neuron (which will convey all rights to the recipients’ or licensees’ or sublicensees’ Perception Neuron SDK Derivatives to Noitom), and you must cause any modified files to carry prominent notices stating that you changed the files;
* 3.5. If the Perception Neuron SDK or a specific element thereof includes a “LICENSE” text file as part of its distribution (the “License Notice”), then any Perception Neuron SDK Derivatives that you distribute with the Perception Neuron SDK in whole or in part must include a readable copy of such attribution notices as are contained within the applicable License Notice file (excluding those notices that do not pertain to any part of the Perception Neuron SDK Derivatives), in at least one of the following places: within a License Notice text file distributed as part of the Perception Neuron SDK Derivatives; within the source form documentation, if provided along with the Perception Neuron SDK Derivatives; or, within a display generated by the Perception Neuron SDK Derivatives, if and wherever such third-party notices normally appear. You must also include in the License Notice file for all Perception Neuron SDK Derivatives a copy of all notices (including any product liability or health and safety notices). The contents of the License Notice file are for informational purposes only and do not modify the License. You may add your own attribution notices within Perception Neuron SDK Derivatives that you distribute, alongside or as an addendum to the License Notice text from the Perception Neuron SDK or any part thereof, provided that such additional attribution notices cannot be construed as modifying the License.
* 3.6. THIS PERCEPTION NEURON SDK AND ANY COMPONENT THEREOF IS PROVIDED BY NOITOM AND ITS CONTRIBUTORS “AS IS” AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL NOITOM AS THE COPYRIGHT OWNER OR ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS PERCEPTION NEURON SDK OR THE PERCEPTION NEURON SDK DERIVATIVES, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
* 4. This License does not grant permission to use the trade names, trademarks, service marks, or product names of Noitom, except as required for reasonable and customary use in describing the origin of the Perception Neuron SDK, or any element thereof, and reproducing the content of the License Notice file. Noitom reserves all rights not expressly granted to you under this License.
* 5. In no event and under no legal theory, whether in tort (including negligence),contract, or otherwise, unless required by applicable law (such as deliberate and grossly negligent acts) or agreed to in writing, shall Noitom or any contributor be liable to you or your licensees or sublicensees for damages, including any direct, indirect, special, incidental, or consequential damages of any character arising as a result of this License or out of the use or inability to use the Perception Neuron SDK, any element thereof or any Perception Neuron SDK Derivatives (including but not limited to damages for loss of goodwill, work stoppage, computer failure or malfunction, or any and all other commercial damages or losses), even if you or such contributor has been advised of the possibility of such damages.
* 6. Your acceptance of the terms and conditions of this License in and of itself and for all Developer Content created as of 1. December 2014, may be evidenced by any of the following: your usage of the Perception Neuron SDK or any element thereof, acceptance of the click-through agreement, or opening the packaging of the downloaded file containing the Perception Neuron SDK or any element thereof. As this License is updated for future releases of the Perception Neuron SDK, you agree to abide by and meet all requirements of future updates of this License for those future Perception Neuron SDK releases as evidenced by the same usage of the Perception Neuron SDK or any element thereof and the future updates of this License will apply for that future Developer Content that may developed for or with that future Perception Neuron SDK or any element thereof (i.e., you cannot sidestep out of the requirements of future updates of the License by developing against an older release of the Perception Neuron SDK or License).
* 7. Noitom reserves the right to terminate this License and all your rights hereunder in the event you materially breach this License and fail to cure such breach within ten (10)business days after notice of breach from Noitom.
* 8. Furthermore, Noitom also reserves the right to cancel or terminate this License foray of the following reasons upon notice to you, subject to the appeal process set forth in Section 14 for a wrongful termination:
* 1.	Intellectual property infringement by you with Developer Content or Perception Neuron SDK Derivatives created by you that is used with or by the Perception Neuron SDK or any part thereof, or any of the Perception Neuron SDK Derivatives;
* 2.	Developer Content that violates or infringes upon applicable law;
* 3.	Health and safety issues associated with your Developer Content;
* 4.	Failure to comply with the Perception Neuron EULA;
* 5.	Use of the Perception Neuron SDK, Perception Neuron SDK Derivatives with a commercial product other than an Noitom Approved Product; and
* 6.	Failure to provide required notices or deliver source code and/or binary of Perception Neuron SDK Derivatives as set forth above.
* If you believe that you have been wrongfully terminated under this Section 8 with respect to material breach or with respect to these above conditions, you have the right to appeal the termination of this License under Section 14.
* 9. This License may be amended by Noitom on a prospective basis, and your usage of the License after such amendments or changes signifies your consent toad acceptance of any such amendments or changes on a going forward basis.
* 10. In the event any provision of this License is determined to be invalid, prohibited or unenforceable by a court or other body of competent jurisdiction, this License shall be construed as if such invalid, prohibited or unenforceable provision has been more narrowly drawn so as not to be invalid, prohibited or unenforceable.
* 11. You may not assign any rights or obligations under this License without the advance written consent of Noitom, which may be withheld in its sole discretion. Noitom may assign its rights or obligations under this License in its sole discretion.
* 12. Failure of either party at any time to enforce any of the provisions of this License will not be construed as a waiver of such provisions or in any way affect the validity of this License or parts thereof.
* 13. Your remedies under this License shall be limited to the right to collect money damages, if any, and you hereby waive your right to injunctive or other equitable relief.
* 14. This License shall be governed by the laws of the State of California, without giving effect to choice of law principles. All disputes relating to this License shall be resolved by binding non-appearance-based arbitration before a neutral arbitrator in Orange County, California. If your License has been terminated hereunder by Noitom, you may appeal your termination through this arbitration process on an expedited basis with an arbitration within thirty days of your giving Noitom notice of the appeal. The arbitration shall be conducted in accordance with the rules and procedures of JAMS then in effect, and the judgment of the arbitrator shall be final and capable of entry in any court of competent jurisdiction. You agree to submit to the personal jurisdiction of the courts located within Orange County, California in connection with any entrance of an arbitrator’s judgment or decision or any dispute with respect to the arbitration processor procedure or Noitom’s exercise of its equitable rights or remedies.
*/

using UnityEngine;
using System.Collections;

public class PNUtils {

	public static void LoadSkeletonReference( Transform[] target, Transform root, string prefix, int boneNameID ) {
		if (root == null) {
			Debug.Log("<color=red>[ERROR]</color> LoadSkeletonReference was called with null root object!");
			return;
		}
		if (target == null) {
			Debug.Log("<color=red>[ERROR]</color> LoadSkeletonReference was called with null target reference list!");
			return;
		}
		
		Transform[] sList = root.GetComponentsInChildren<Transform> ();
		//Transform[] tsList = Skeleton_Target_Root.GetComponentsInChildren<Transform> ();
		
		for (int i=0; i < target.Length; i++) {
			target[i] = FindBone(sList, prefix + GetBoneName(boneNameID,i) );
		}
		
		Debug.Log ("Loaded Skeleton Reference for target object: " + root.name);
	}

	public static Transform FindBone(Transform[] list, string name) {
		for (int i=0; i < list.Length; i++) {
			if ( list[i].name == name ) {
				return list[i];
			}
		}
		
		//if we get this far it means we didn't find a object with the input name
		Debug.Log("Did not find the bone object [" + name +"]!");
		return null;
	}
	public static string GetBoneName(int type, int index) {
		// Default names for Perception Neuron BVH structure
		if ( type == 0 ) {
			if (index==0) 	return "Hips";
			if (index==1) 	return "RightUpLeg";
			if (index==2) 	return "RightLeg";
			if (index==3) 	return "RightFoot";
			if (index==4) 	return "LeftUpLeg";
			if (index==5) 	return "LeftLeg";
			if (index==6) 	return "LeftFoot";
			if (index==7) 	return "Spine";
			if (index==8) 	return "Spine1";
			if (index==9) 	return "Spine2";
			if (index==10) 	return "Spine3";
			if (index==11) 	return "Neck"; 
			if (index==12)	return "Head";
			if (index==13)	return "RightShoulder";
			if (index==14)	return "RightArm";
			if (index==15)	return "RightForeArm";
			if (index==16)	return "RightHand";
			if (index==17)	return "RightHandThumb1";
			if (index==18)	return "RightHandThumb2";
			if (index==19)	return "RightHandThumb3";
			if (index==20)	return "RightInHandIndex";
			if (index==21)	return "RightHandIndex1";
			if (index==22)	return "RightHandIndex2";
			if (index==23)	return "RightHandIndex3";
			if (index==24)	return "RightInHandMiddle";
			if (index==25)	return "RightHandMiddle1";
			if (index==26)	return "RightHandMiddle2";
			if (index==27)	return "RightHandMiddle3";
			if (index==28)	return "RightInHandRing";
			if (index==29)	return "RightHandRing1";
			if (index==29)	return "RightHandRing1";
			if (index==30)	return "RightHandRing2";
			if (index==31)	return "RightHandRing3";
			if (index==32)	return "RightInHandPinky";
			if (index==33)	return "RightHandPinky1";
			if (index==34)	return "RightHandPinky2";
			if (index==35)	return "RightHandPinky3";
			if (index==36)	return "LeftShoulder";
			if (index==36)	return "LeftShoulder";
			if (index==36)	return "LeftShoulder";
			if (index==36)	return "LeftShoulder";
			if (index==37)	return "LeftArm";
			if (index==38)	return "LeftForeArm";
			if (index==39)	return "LeftHand";
			if (index==40)	return "LeftHandThumb1";
			if (index==41)	return "LeftHandThumb2";
			if (index==42)	return "LeftHandThumb3";
			if (index==43)	return "LeftInHandIndex";
			if (index==44)	return "LeftHandIndex1";
			if (index==45)	return "LeftHandIndex2";
			if (index==46)	return "LeftHandIndex3";
			if (index==47)	return "LeftInHandMiddle";
			if (index==48)	return "LeftHandMiddle1";
			if (index==49)	return "LeftHandMiddle2";
			if (index==50)	return "LeftHandMiddle3";
			if (index==51)	return "LeftInHandRing";
			if (index==52)	return "LeftHandRing1";
			if (index==53)	return "LeftHandRing2";
			if (index==54)	return "LeftHandRing3";
			if (index==55)	return "LeftInHandPinky";
			if (index==56)	return "LeftHandPinky1";
			if (index==57)	return "LeftHandPinky2";
			if (index==58)	return "LeftHandPinky3";
		} else if ( type == 1 ) { // 3D Studio Max biped setup Test
			/// Test to automatically load reference by the default names used with the biped bones tool in 3DS Max.
			/// May not work properly with displacement data because there is no InHand bone for each finger.
			if (index==0)	return "Pelvis";
			if (index==1) 	return "R Thigh";
			if (index==2) 	return "R Calf";
			if (index==3) 	return "R Foot";
			if (index==4) 	return "L Thigh";
			if (index==5) 	return "L Calf";
			if (index==6) 	return "L Foot";
			if (index==7)	return "Spine";
			if (index==8) 	return "Spine1";
			if (index==0) 	return "Spine2";
			if (index==10) 	return "Spine3";
			if (index==11) 	return "Neck";
			if (index==12) 	return "Head";
			if (index==13) 	return "R Clavicle";
			if (index==14) 	return "R UpperArm";
			if (index==15) 	return "R Forearm";
			if (index==16) 	return "R Hand";
			if (index==17) 	return "R Finger0";
			if (index==18) 	return "R Finger01";
			if (index==19) 	return "R Finger02";
			// no InHand bone for id 20 with 3ds max setup
			if (index==21) 	return "R Finger1";
			if (index==22) 	return "R Finger11";
			if (index==23) 	return "R Finger12";
			// no InHand bone for id 24 with 3ds max setup
			if (index==25) 	return "R Finger2";
			if (index==26) 	return "R Finger21";
			if (index==27) 	return "R Finger22";
			// no InHand bone for id 28 with 3ds max setup
			if (index==29) 	return "R Finger3";
			if (index==30) 	return "R Finger31";
			if (index==31) 	return "R Finger32";
			// no InHand bone for id 32 with 3ds max setup
			if (index==33) 	return "R Finger4";
			if (index==34) 	return "R Finger41";
			if (index==35) 	return "R Finger42";
			if (index==36) 	return "L Clavicle";
			if (index==37) 	return "L UpperArm";
			if (index==38) 	return "L Forearm";
			if (index==39) 	return "L Hand";
			if (index==40) 	return "L Finger0";
			if (index==41) 	return "L Finger01";
			if (index==42) 	return "L Finger02";
			// no InHand bone for id 43 with 3ds max setup
			if (index==44) 	return "L Finger1";
			if (index==45) 	return "L Finger11";
			if (index==46) 	return "L Finger12";
			// no InHand bone for id 47 with 3ds max setup
			if (index==48) 	return "L Finger2";
			if (index==49) 	return "L Finger21";
			if (index==50) 	return "L Finger22";
			// no InHand bone for id 51 with 3ds max setup
			if (index==52) 	return "L Finger3";
			if (index==53) 	return "L Finger31";
			if (index==54) 	return "L Finger32";
			// no InHand bone for id 55 with 3ds max setup
			if (index==56) 	return "L Finger4";
			if (index==57) 	return "L Finger41";
			if (index==58) 	return "L Finger42";
		} else {
			Debug.Log("<color=red>[ERROR] No naming setup found for the received input type id: </color>" + type);
		}
		return "";
	}
}
