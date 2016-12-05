using IuTubi.CQRS.CommandStack.Application.Commands;
using IuTubi.CQRS.CommandStack.Application.Services;
using IuTubi.CQRS.CommandStack.Domain.Models;
using IuTubi.CQRS.CommandStack.Domain.Repositories;

namespace IuTubi.CQRS.CommandStack.Application.Handlers
{
    public class VideoCommandHandler :
        ICanHandle<RegisterVideoMetadataCommand>,
        ICanHandle<UploadVideoStreamCommand>,
        ICanHandle<RegisterNewViewCommand>
    {

        private readonly IBus _bus;
        private readonly IVideoRepository _repository;
        private readonly IFileStorageService _service;

        public VideoCommandHandler(IBus bus, IVideoRepository repository, IFileStorageService service)
        {
            _bus = bus;
            _repository = repository;
            _service = service;
        }

        public void Handle(RegisterNewViewCommand message)
        {
            var id = new VideoId(message.VideoId);
            _repository.RegisterNewView(id);
        }

        public void Handle(UploadVideoStreamCommand message)
        {
            var video = _repository.FindById(new VideoId(message.VideoId));
            var url = _service.Send(message.File, message.FileName);
            var file = new VideoFile(video.Id, message.Name, url);

            video.AttachFile(file);

            _repository.Update(video);
        }

        public void Handle(RegisterVideoMetadataCommand message)
        {
            var video = Video.Factory.New(message);
            _repository.Register(video);
        }
    }
}
