using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    //��ũ���� �ӵ��� ����� ����
    public float scrollSpeed = 0.1f;
    //������ ���͸��� �����͸� �޾ƿ� ��ü�� �����մϴ�.
    private Material thisMaterial;

    void Start()
    {
        //��ü�� �����ɶ� ���� 1ȸ ȣ��Ǵ� �Լ�
        //���� ��ü�� component���� ������ renderer��� �����ͤ�Ʈ�� material����
        //�޾ƿ�
        thisMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //���Ӱ� �������� Offset ��ü�� �����մϴ�.
        Vector2 newoffset = thisMaterial.mainTextureOffset;
        //Y�κп� ���� y���� �ӵ��� �����Ӻ����ؼ� �����ݴϴ�.
        newoffset.Set(0, newoffset.y + (scrollSpeed * Time.deltaTime));
        //���������� offset ���� �������ش�.
        thisMaterial.mainTextureOffset = newoffset;
    }
}
