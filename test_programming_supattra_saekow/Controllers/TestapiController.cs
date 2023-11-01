using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using test_programming_supattra_saekow.Models;

namespace PostAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // สร้าง HttpClient
            HttpClient client = new HttpClient();

            // สร้าง HttpRequestMessage
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/posts");

            // ส่งคำขอ
            HttpResponseMessage response = client.SendAsync(request).Result;

            // ตรวจสอบสถานะ
            if (response.IsSuccessStatusCode)
            {
                // แปลง JSON เป็นรายการ Post
                List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(response.Content.ReadAsStringAsync().Result);

                // แสดงข้อมูล
                foreach (Post post in posts)
                {
                    Console.WriteLine($"Id: {post.Id}, Title: {post.Title}, Body: {post.Body}, UserId: {post.UserId}, UserName: {post.UserName}");
                }
            }
            else
            {
                // แสดงข้อผิดพลาด
                Console.WriteLine(response.StatusCode);
            }

            // ปิดการเชื่อมต่อ
            client.Dispose();
        }
    }
}