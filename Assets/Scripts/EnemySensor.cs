using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySensor : MonoBehaviour {

    public Vector3 directionToSearch = new Vector3(0f, 0f, 2f);
    public LayerMask obstacleLayer;

    Node m_nodeToSearch;
    Board m_board;

    bool m_foundPlayer = false;
    public bool FoundPlayer { get { return m_foundPlayer; } }

    private void Awake()
    {
        m_board = Object.FindObjectOfType<Board>().GetComponent<Board>();
    }


    public void UpdateSensor()
    {
        Vector3 worldSpacePositionToSearch = transform.TransformVector(directionToSearch)
            + transform.position;
        if (m_board != null)
        {
            m_nodeToSearch = m_board.FindNodeAt(worldSpacePositionToSearch);
            bool obs = FindObstacle(m_nodeToSearch);

            if (m_nodeToSearch == m_board.PlayerNode && obs == false)
            {
                m_foundPlayer = true;
            }

        }
    }

    bool FindObstacle(Node targetNode)
    {

        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, Board.spacing + 0.1f))       
            {
            if (raycastHit.transform.gameObject.tag == "Bloc")
            {
                //Debug.Log(this.transform.gameObject.name);
                return true;
            }

        }
        return false;
    }




}
