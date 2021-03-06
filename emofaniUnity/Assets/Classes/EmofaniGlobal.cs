using UnityEngine;
using System.Collections;

/// <summary>
/// Base class for all Emofani classes. Contains some convenience methods.
/// </summary>
public class EmofaniGlobal : MonoBehaviour
{

	protected UdpListener udp;
	protected EmofaniGUI guiScript;
	protected FaceAnimator faceAnimator;
	protected Camera mainCamera;

	/// <summary>
	/// Gets the UDPListener component from the scene
	/// </summary>
	/// <value>The UDPListener.</value>
	protected UdpListener Listener {
		get {
			if (this.udp == null) {
				GameObject udpObj = GameObject.Find("UDPListener");
				if (udpObj != null) {
					this.udp = udpObj.GetComponent<UdpListener>();
				}
			}
			return this.udp;
		}
	}

	/// <summary>
	/// Gets the EmofaniGUI component from the scene
	/// </summary>
	/// <value>The GUI script.</value>
	protected EmofaniGUI GuiScript {
		get {
			if (this.guiScript == null) {
				GameObject guiObject = GameObject.Find("MainCamera");
				if (guiObject != null) {
					this.guiScript = guiObject.GetComponent<EmofaniGUI>();
				}
			}
			return this.guiScript;
		}
	}

	/// <summary>
	/// Gets the FaceAnimator component from the scene
	/// </summary>
	/// <value>The face animation.</value>
	protected FaceAnimator FaceAnim {
		get {
			if (this.faceAnimator == null) {
				GameObject faceObject = GameObject.Find("Face");
				if (faceObject != null) {
					this.faceAnimator = faceObject.GetComponent<FaceAnimator>();
				}
			}
			return this.faceAnimator;
		}
	}

	/// <summary>
	/// Gets the camera component from the scene
	/// </summary>
	/// <value>The main camera.</value>
	protected Camera MainCamera {
		get {
			if (this.mainCamera == null) {
				GameObject cameraObject = GameObject.Find("MainCamera");
				if (cameraObject != null) {
					this.mainCamera = cameraObject.GetComponent<Camera>();
				}
			}
			return this.mainCamera;
		}
	}

}